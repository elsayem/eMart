using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ProductPicture { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity {  get; set; }

        public byte[]? Thumbnail { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        
        //Nav Properties
        public virtual ICollection <OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }

        public int CategoryId {  get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductPicture> ProductPictures { get; set;}
        public virtual ICollection<ProductReview> ProductReviews { get; set;}


    }
}
