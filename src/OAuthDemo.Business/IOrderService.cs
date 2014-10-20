using OAuthDemo.Business.Models;
using System.Collections.Generic;

namespace OAuthDemo.Business
{
    public interface IOrderService
    {
        IEnumerable<OrderModel> Get();
    }
}