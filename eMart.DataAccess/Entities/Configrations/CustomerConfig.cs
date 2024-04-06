using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities.Configrations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //pk
            builder.HasKey(x=>x.Id);

            //Relations
            //<Customer> to indicate that the foriegn key in the Customer
            builder.HasOne(x => x.WishList)
                .WithOne(x => x.Customer)
                .HasForeignKey<Customer>(x => x.WishListId);

            builder.HasOne(x => x.Cart)
                .WithOne(x => x.Customer)
                .HasForeignKey<Customer>(x => x.CartId);
        }
    }
}
