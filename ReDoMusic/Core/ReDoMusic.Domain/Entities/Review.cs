using System;

namespace ReDoMusic.Domain.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}


