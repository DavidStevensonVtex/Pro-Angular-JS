using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SportsStore.Controllers
{
    [Route("products/{id?}")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            //throw new Exception("Failed to get data from repository.");
            //throw new HttpResponseException(HttpStatusCode.BadRequest);
            return Repository.Products;
        }

        [HttpPost]
        public Product PostProduct([FromBody] Product product)
        {
            product.Id = Repository.Products.Max(p => p.Id) + 1;
            Repository.Products.Add(product);
            return product;
        }

        [HttpPut]
        public Product PutProduct([FromBody] Product product)
        {
            Product newProduct = Repository.Products.Find(p=> p.Id == product.Id);
            newProduct.Price = product.Price;
            newProduct.Category = product.Category;
            newProduct.Description = product.Description;
            newProduct.Name = product.Name;
            return newProduct;
        }

        [HttpDelete]
        public Product DeleteProduct(int id)
        {
            Product product = Repository.Products.Find(p => p.Id == id);
            if (product != null)
            {
                Repository.Products.Remove(product);
            }

            return product;
        }
    }
}
