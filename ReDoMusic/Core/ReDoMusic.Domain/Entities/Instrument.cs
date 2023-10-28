using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Domain.Entities
{
    public class Instrument : EntityBase<Guid> //Id'yi guid aldık.
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; } 
        public decimal Price { get; set; }
        public Color Color { get; set; }
        public DateTime? ProductionYear { get; set; }
        public string Barcode { get; set; }
        public string PictureUrl { get; set; }
    }
}
