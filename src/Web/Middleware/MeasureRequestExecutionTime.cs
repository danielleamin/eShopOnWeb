using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Web.Middleware
{
    public class MeasureRequestExecutionTime
    {
        private readonly ILogger<MeasureRequestExecutionTime> _logger;
        private readonly RequestDelegate _next;
        public MeasureRequestExecutionTime(
            RequestDelegate next,
            ILogger<MeasureRequestExecutionTime> logger
        ) {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext) {
            // Pedido
            var requestStartDate = DateTimeOffset.Now;
            _logger.LogInformation("Request started at {requestStartDate}", requestStartDate);
            await _next(httpContext);
            var requestEndDate = DateTimeOffset.Now;
            var durationMs = (requestEndDate - requestStartDate).TotalMilliseconds;
            _logger.LogInformation("Request ended at {requestEndDate} took {durationMS} ms",
             requestEndDate, durationMs);

            // Resposta
            
        }
    }
} 
