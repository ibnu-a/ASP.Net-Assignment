using ASPNet_API_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ASPNet_MVC_Project.Controllers
{
    public class EmployeesController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44342/API/")
        };
        // GET: Employees
        public ActionResult Index()
        {
            IEnumerable<Employees> employees = null;
            var respondTask = client.GetAsync("Employees");
            respondTask.Wait();
            var result = respondTask.Result;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Employees>>();
                readTask.Wait();
                employees = readTask.Result;
            }
            return View(employees);
        }
    }
}