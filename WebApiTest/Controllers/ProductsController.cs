using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class ProductsController : ApiController
    {

        static List<Product> _products = new List<Product>()
        {

            new Product(){Id=0,price="150",productName="Laptop"},
            new Product(){Id=1,price="300",productName="xbox"},
        };

        public IHttpActionResult Get()
        {
            return Ok(_products);
        }

        public HttpResponseMessage Post([FromBody]Product product)
        {
            _products.Add(product);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public void Put(int id,[FromBody]Product product)
        {
            _products[id] = product;
        }

        public void Delete(int id)
        {
            _products.RemoveAt(id);
        }
    }
}
