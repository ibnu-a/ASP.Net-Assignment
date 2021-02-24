using Api.ViewModels;
using ASPNet_API_Project.Repositories;
//using ASPNet_API_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASPNet_API_Project.Controllers
{
    public class AccountController : ApiController
    {
        readonly AccountsRepository accountsRepository = new AccountsRepository();
        public IHttpActionResult Post(Register register)
        {
            accountsRepository.Create(register);
            return Ok("Successfully");
        }

        public IHttpActionResult Put(int id, Register register) //untuk update dengan put
        {
            if (accountsRepository.Update(id, register) == 1)
            {
                return Ok("Successfully");
            }
            else
            {
                return BadRequest("Register data cannot be changed");
            }
        }

        public Task<Register> Get(int Id)
        {
            return accountsRepository.Get(Id);
        }

        public IHttpActionResult Delete(int id)
        {
            if (accountsRepository.Delete(id) == 1)
            {
                return Ok("Successfully");
            }
            else
            {
                return BadRequest("Data Not Available");
            }
        }
    }
}
