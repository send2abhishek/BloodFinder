using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductDbContext db = new ProductDbContext();

       

        public IEnumerable<Product> Get()
        {

            return db.Products;
        }

        public IHttpActionResult Post(Product product)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(product);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        public IHttpActionResult Put(int id,Product product)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }

            var result = db.Products.FirstOrDefault(productId => product.Id == id);

            if (result == null)
            {

                return BadRequest("No records found on this id");
            }

            result.productName = product.productName;
            result.price = product.price;
            db.SaveChanges();
            return Ok("The records has been updated...");
        }

        public IHttpActionResult Delete(int id)
        {
            var result = db.Products.Find(id);
            if (result == null)
            {
                return NotFound();
            }

            db.Products.Remove(result);
            db.SaveChanges();
            return Ok("Deleted suceesfully...");
        }
    }
}