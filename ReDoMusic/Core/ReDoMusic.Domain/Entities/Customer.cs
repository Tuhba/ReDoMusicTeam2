using ReDoMusic.Domain.Common;
using System;

namespace ReDoMusic.Domain.Entities
{
    public class Customer : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
