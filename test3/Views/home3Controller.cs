using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace test3.Views
{
    public class home3Controller : Controller
    {
        // GET: home3
        public ActionResult Index()
        {
            
            return View();
        }
    }
}



//using (var client = new HttpClient())
//{
//    client.BaseAddress = new Uri("http://192.168.43.170:80");
//}