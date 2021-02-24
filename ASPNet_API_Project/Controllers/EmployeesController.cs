using ASPNet_API_Project.Models;
using ASPNet_API_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNet_API_Project.Controllers
{
    public class EmployeesController : ApiController
    {
        readonly EmployeesRepository employeesRepository = new EmployeesRepository();

        public IEnumerable<Employees> Get()
        {
            return employeesRepository.Get();
        }

    }
}
