﻿using Microsoft.eShopWeb.Web;
using Microsoft.eShopWeb.Web.Extensions;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.Web.Extensions.CacheHelpersTests
{
    public class GenerateCatalogItemCacheKey_Should
    {
        [Fact]
        public void ReturnCatalogItemCacheKey()
        {
            var pageIndex = 0;
            string searchText = null;
            int? brandId = null;
            int? typeId = null;

            var result = CacheHelpers.GenerateCatalogItemCacheKey(pageIndex, Constants.ITEMS_PER_PAGE, searchText, brandId, typeId);

            Assert.Equal("items-0-10--", result);
        }
    }
}