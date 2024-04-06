using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities.Configrations
{
    public class OrderProductConfig : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            //PK - Composite PK
            builder.HasKey(x => new { x.ProductId, x.OrderId });

            //Relations
            builder.HasOne(x => x.Product).
                WithMany(x=>x.OrderProducts)
                .HasForeignKey(x=>x.ProductId);

            builder.HasOne(x=>x.Order).
                WithMany(x=>x.OrderProducts)
                .HasForeignKey(x=>x.OrderId);


        }
    }
}
