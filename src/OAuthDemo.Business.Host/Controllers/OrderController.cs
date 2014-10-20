using Microsoft.AspNet.Mvc;
using OAuthDemo.Business.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OAuthDemo.Business.Host.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderService { get; set; }

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public IEnumerable<OrderModel> Get()
        {
            return orderService.Get(); ;
        }
    }
}
