﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class CartProduct
    {
        public int Id { get; set; }        
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int CartId {  get; set; }
        public virtual Cart? Cart { get; set; }



    }
}
