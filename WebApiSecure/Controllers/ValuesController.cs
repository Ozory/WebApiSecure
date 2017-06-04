using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSecure.Controllers
{
    public class ValuesController : ApiController
    {
        [Authorize()]
        [HttpGet()]
        public List<String> Get()
        {
            return  new List<String>() { "Values 1", "Values 2"};
        }
    }
}
