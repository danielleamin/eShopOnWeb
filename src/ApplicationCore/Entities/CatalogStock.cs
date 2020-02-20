using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogStock : BaseEntity, IAggregateRoot

    {
        public int Stock {get; set;} =0;

        public int StoreId {get; set;}

        public int ItemId { get; set;}
        
        #region "Navigation properties"
        public CatalogStore Store { get; set; }
        public CatalogItem Item { get; set; }
        #endregion
    }
}