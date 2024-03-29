﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}
