using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TokenAuthMVC.Managers;

namespace TokenAuthMVC.Controllers
{
    public class IpController : ApiController
    {
        //[HttpGet]
        [AcceptVerbs("GET")]
        public string Index()
        {
            return CommonManager.GetIP(HttpContext.Current);
        }
    }
}