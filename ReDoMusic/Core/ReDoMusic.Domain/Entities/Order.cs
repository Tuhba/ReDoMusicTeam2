using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Entities
{
    public class Order :EntityBase<Guid>
    {
        public String OrderId { get; set; }
        public  OrderStatus OrderStatus{ get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate {get;set;}


    }
}
