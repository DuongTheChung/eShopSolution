﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class OrderDetail
    {
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public int OrderId { set; get; }
        public Order Order { get; set; }

        public int ProductId { set; get; }
        public Product Product { get; set; }
    }
}
