using OAuthDemo.Business.Models;
using System.Collections.Generic;

namespace OAuthDemo.Business
{
    public class OrderService : IOrderService
    {
        public IEnumerable<OrderModel> Get()
        {
            return new List<OrderModel>
            {
                new OrderModel { Instrument = "Apple Inc.", Price = 101.91m, Quantity = 30, UserId = "User1" },
                new OrderModel { Instrument = "Google Inc.", Price = 312.56m, Quantity = 10, UserId = "User2" },
                new OrderModel { Instrument = "Nike Corp", Price = 72.50m, Quantity = 45, UserId = "User3" },
            };
        }
    }
}