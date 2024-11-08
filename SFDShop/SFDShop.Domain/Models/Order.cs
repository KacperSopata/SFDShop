﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDShop.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }  
        public bool isDone { get; set; }
        public int CountOfItems { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
    }
}
