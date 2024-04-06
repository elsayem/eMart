using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte[]? ProfileImage { get; set; }

        public int WishListId {  get; set; }
        public virtual WishList WishList { get; set;}

        public int CartId {  get; set; }
        public virtual Cart Cart { get; set; }


    }
}
