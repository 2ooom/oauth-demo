using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using ResourceServer.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceServer.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
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
