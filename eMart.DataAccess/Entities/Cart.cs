using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public Customer Customer { get; set; }

    }
}
