using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities.Configrations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //PK
            builder.HasKey(x => x.Id);

            //Relations
            builder.HasMany(x => x.ProductPictures)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x=>x.ProductReviews)
                .WithOne(x=>x.Product)
                .HasForeignKey(x => x.ProductId);

            //index
            builder.HasIndex(x => x.Name)
                .IsUnique();

                
        }
    }
}
