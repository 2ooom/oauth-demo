using System;

namespace ResourceServer.Models
{
    public class OrderModel
    {
        public string Instrument { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime PlacedDate { get; set; }
        public string UserId { get; set; }
    }
}