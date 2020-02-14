using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogStock : BaseEntity, IAggregateRoot

    {
        public int Stock {get; set;} =0;

        public int BrandId { get; set; }

        public int StoreId {get; set;}

        public int ItemId { get; set;}
        

    }
}