using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.Infrastructure.Data.Config
{
    public class CatalogStockConfiguration : IEntityTypeConfiguration<CatalogStock>
    {
        public void Configure(EntityTypeBuilder<CatalogStock> builder)
        {
            builder.ToTable("Catalog");

            builder.Property(ci => ci.Id)
                .UseHiLo("catalog_hilo")
                .IsRequired();

            builder.Property(ci => ci.Stock)
                .IsRequired(true)
                .HasDefaultValue(0);

            builder.HasOne(ci => ci.Store)
                .WithMany()
                .HasForeignKey(ci => ci.StoreId);

            builder.HasOne(ci => ci.Item)
                .WithMany()
                .HasForeignKey(ci => ci.CatalogTypeId);
        }
    }
}
