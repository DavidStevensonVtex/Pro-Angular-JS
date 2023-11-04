using SportsStore.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SportsStore.Controllers
{
    public class ProductsController : ApiController
    {
        [Route("products")]
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return Repository.Products;
        }
    }
}
