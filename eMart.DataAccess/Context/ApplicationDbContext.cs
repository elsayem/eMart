using eMart.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //this line will apply all Configrations Instead of use applyconfigration for every config
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public virtual DbSet<Category> Categories {  get; set; }
        public virtual DbSet<Cart> Carts {  get; set; }
        public virtual DbSet<Customer> Customers {  get; set; }
        public virtual DbSet<Product> Products {  get; set; }
        public virtual DbSet<WishList> WishLists {  get; set; }
        public virtual DbSet<Order> Orders {  get; set; }

        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<CartProduct> CartProducts { get; set; }
        public virtual DbSet<ProductPicture> ProductPictures { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }    


    }
}
