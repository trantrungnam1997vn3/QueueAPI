using QueueLogic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueueLogic.Models
{
    public class ProductController : ApiController
    {
        // Ghi log
        // Merge sp va danh muc
        // Them 20 sp cung luc
        // Xoa 10 sp
        
        [HttpGet]
        public IHttpActionResult WriteLog()
        {
            
            QueueProccess.Sync();
            return Ok<String>("hello");
        }
    }
}
