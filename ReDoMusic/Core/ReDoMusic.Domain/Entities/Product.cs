using System;
using System.Collections.Generic;

namespace ReDoMusic.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
