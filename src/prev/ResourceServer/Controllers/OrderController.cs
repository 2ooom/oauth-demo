using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using ResourceServer.Business.Models;
using ResourceServer.Business;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ResourceServer.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private IOrderService orderService { get; set; }

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;

        }
        // GET: /<controller>/
        public IEnumerable<OrderModel> Get()
        {
            return orderService.Get();
        }
    }
}
