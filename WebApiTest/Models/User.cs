using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiTest.Models
{
    public class User
    {

        public int id { get; set; }

        [Required,StringLength(15)]
        public string UserName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email in not valid")]
        public string Email { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
    }
}