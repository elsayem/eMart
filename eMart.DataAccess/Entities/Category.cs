using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        //[Required(ErrorMessage("Name is Required"))]
        public string Name { get; set; }
        public string? Description { get; set; }
        //public int ProductId { get; set; }

        public byte[]? Thumbnail { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;
                


        public virtual ICollection<Product> Products { get; set; }



    }
}
