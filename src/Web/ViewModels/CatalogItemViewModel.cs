using System.Collections.Generic;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.Web.ViewModels
{
    public class StockInStore {
        public string StoreName {get; set;}
        public int Stock {get; set;}
    }

    public class CatalogItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUri { get; set; }
        public decimal Price { get; set; }
        public bool ShowPrice { get; set; }
        public Currency PriceUnit {get; set;}
        
        public IList<StockInStore> Stocks {get; set;}

    }
}