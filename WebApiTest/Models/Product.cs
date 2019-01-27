using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiTest.Models
{
    public class Product
    {

        public int Id { get; set; }

        //[Required, StringLength(2)]
        public string productName { get; set; }

        //[Required, StringLength(2)]
        public string price { get; set; }

    }
}