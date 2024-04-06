using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities.Configrations
{
    public class CartProductConfig : IEntityTypeConfiguration<CartProduct>
    {
        public void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            //PK Composite-Key
            builder.HasKey(x => new { x.CartId, x.ProductId });

            //Relations
            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartProducts)
                .HasForeignKey(x => x.CartId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.CartProducts)
                .HasForeignKey(x => x.ProductId);




        }
    }
}
