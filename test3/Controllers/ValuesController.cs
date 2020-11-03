using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test3.Models;

namespace test3.Controllers
{
    public class ValuesController : ApiController
    {
        
       
       [HttpPost]
        public String Post([FromBody] string value)
        {
           
            message msg = new message();
            msg.Mesg = value;
         
            return value;
        }
        
       
    }
}
