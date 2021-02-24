using Api.ViewModels;
using ASPNet_API_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ASPNet_MVC_Project.Controllers
{
    public class LoginController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44342/API/")
        };
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Register register)
        {
            
            IEnumerable<Register>login = null;
            var responTask = client.GetAsync("Register");
            responTask.Wait();
            var result = responTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Register>>();
                readTask.Wait();
                login = readTask.Result;

                return RedirectToAction("Details", "Register", new { id = login.FirstOrDefault(s => s.EmailAddress == register.AccountPassword).Id });
            }
                return RedirectToAction("Login", "Login");
        }
    }
}