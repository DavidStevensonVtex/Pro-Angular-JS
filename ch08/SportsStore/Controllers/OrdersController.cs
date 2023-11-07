using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportsStore.Controllers
{
    public class OrdersController : ApiController
    {
        [Route("products")]
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            //throw new Exception("Failed to get data from repository.");
            //throw new HttpResponseException(HttpStatusCode.BadRequest);
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
