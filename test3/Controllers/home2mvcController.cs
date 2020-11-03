using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace test3.Controllers
{
    public class home2mvcController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> TurnOnLed()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.43.200:80/api/values?value=ON");
                var content = new StringContent("{\"foo\":\"bar\"}", Encoding.UTF8, "application/json");
                await client.PostAsync(client.BaseAddress, content);
            }
            return RedirectToAction("Index", "home3mvc");
        }
    }
    




























    //public class home2mvcController : Controller
    //{
       
    //    public ActionResult Index()
    //    {
    //        IEnumerable<string> temp = null;
    //        using (var client = new HttpClient())
    //        {
    //          //  client.BaseAddress = new Uri("http://10.10.10.180:80");
    //            client.BaseAddress = new Uri("http://localhost:1069/api/Values");
    //            var responseTask = client.GetAsync("Values");

    //            var result = responseTask.Result;
    //            if (result.IsSuccessStatusCode) //if response is 200 ok 
    //            {

    //                var readTask = result.Content.ReadAsAsync<IList<string>>();
    //                readTask.Wait(); //wait for finishing read

    //                temp = readTask.Result;
    //            }
    //            else //web api sent error response 
    //            {
                    

    //                temp = Enumerable.Empty<string>();

    //                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
    //            }
    //        }
    //        return View();
    //    }

    }
