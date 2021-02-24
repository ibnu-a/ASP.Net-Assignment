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
    public class RegisterController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44342/API/")
        };
        // GET: Register
   

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register (Register register)
        {
            HttpResponseMessage respons = client.PostAsJsonAsync("Register", register).Result;
            return RedirectToAction("Login", "Login");
        }

        public ActionResult Edit(int Id)
        {
            IEnumerable<Register> registers = null;
            var details = client.GetAsync("Supplier/" + Id);
            details.Wait();
            var result = details.Result; //?

            var readTask = result.Content.ReadAsAsync<IList<Register>>();
            readTask.Wait();
            registers = readTask.Result;

            return View(registers.FirstOrDefault(s => s.Id == Id));
        }
        [HttpPost]
        public ActionResult Edit(int Id, Register register)
        {
            var response = client.PutAsJsonAsync<Register>("Register/" + register.Id, register);
            response.Wait();

            return RedirectToAction("Login", "Login");
        }
        public ActionResult Details(int id)
        {
            IEnumerable<Register> item = null;

            var details = client.GetAsync("Register/" + id);
            details.Wait();
            var result = details.Result;

            var readTask = result.Content.ReadAsAsync<IList<Register>>();
            readTask.Wait();
            item = readTask.Result;

            return View(item.FirstOrDefault(i => i.Id == id));
        }

    }
}