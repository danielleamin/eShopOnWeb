using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogStock : BaseEntity, IAggregateRoot

    {
        public string Stock {get; set;}
        public decimal Quantity {get; set;}
        public int CatalogTypeId { get; set; }
        public int CatalogBrandId { get; set; }

        public int CatalogStoreId {get; set;}

    }
}