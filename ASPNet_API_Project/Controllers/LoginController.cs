using Api.ViewModels;
using ASPNet_API_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNet_API_Project.Controllers
{
    public class LoginController : ApiController
    {
        readonly AccountsRepository accountsRepository = new AccountsRepository();

        public IHttpActionResult Post(Register register)
        {
            var Email = register.EmailAddress;
            var Password = register.EmailAddress;

            var result = accountsRepository.Login().FirstOrDefault(r => r.EmailAddress == Email && r.AccountPassword == Password);
            if (result != null)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
