﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMart.DataAccess.Entities
{
    public class ProductPicture
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
