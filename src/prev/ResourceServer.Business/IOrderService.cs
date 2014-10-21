
using ResourceServer.Business.Models;
using System.Collections.Generic;

namespace ResourceServer.Business
{
    public interface IOrderService
    {
        IEnumerable<OrderModel> Get();
    }
}