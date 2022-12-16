using EKZKPZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKZKPZ.DTOs
{
    public class ClothingDTO
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public DateTime ProductionDate { get; set; }
        public Size Size { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
    }
}
