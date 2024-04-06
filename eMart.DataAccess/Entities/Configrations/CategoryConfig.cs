using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace eMart.DataAccess.Entities.Configrations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //PK
            builder.HasKey(x => x.Id);

            //Relations
            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
            
            //index
            builder.HasIndex(x => x.Name)
                .IsUnique();


            //Constraints



        }
    }
}
//PK

//Relations

//Constraints