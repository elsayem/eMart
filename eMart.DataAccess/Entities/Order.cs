using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedaAt { get; set; }
        public bool IsDeleted { get; set; } =false;

        public virtual ICollection <OrderProduct> OrderProducts { get; set; }
    }
    
}
