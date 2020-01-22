using System.Threading;
using System.Threading.Tasks;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Web.Services
{
    public class CurrencyServiceStatic : ICurrencyService
    {
        public Task<decimal> Convert(decimal value, Currency source, Currency target, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}