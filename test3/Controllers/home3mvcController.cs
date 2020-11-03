using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace test3.Controllers
{
    public class home3mvcController : Controller
    {
        // GET: home3mvc
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> TurnOffLed()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.43.200:80/api/values?value=OFF");
                var content = new StringContent("{\"foo\":\"bar\"}", Encoding.UTF8, "application/json");
                var a = await client.PostAsync(client.BaseAddress, content);
            }
            return RedirectToAction("Index", "home2mvc");
        }
    }
}