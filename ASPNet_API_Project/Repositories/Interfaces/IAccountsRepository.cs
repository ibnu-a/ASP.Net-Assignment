using Api.ViewModels;
//using ASPNet_API_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNet_API_Project.Repositories.Interfaces
{
    interface IAccountsRepository
    {
        Task<IEnumerable<Register>> Post(Register register);
        int Create(Register register); //merujuk ke model
        int Update(int Id, Register register);
        Task<Register> Get(int id);
        int Delete(int id);
    }
}
