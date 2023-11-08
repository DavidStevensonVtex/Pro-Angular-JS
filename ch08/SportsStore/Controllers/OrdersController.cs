using SportsStore.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SportsStore.Controllers
{
    public class OrdersController : ApiController
    {
        [Route("orders")]
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return OrderRepository.Orders;
        }

        [Route("orders")]
        [HttpPost]
        public void PostOrder(Order order)
        {
            OrderRepository.Orders.Add(order);
        }
    }
}
