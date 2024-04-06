using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class ProductReview
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }



        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
