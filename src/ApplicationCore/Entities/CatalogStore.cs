using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogStore : BaseEntity, IAggregateRoot

    {
        public string Store {get; set;}

        public int StoreId {get; set;}

        
    }
}