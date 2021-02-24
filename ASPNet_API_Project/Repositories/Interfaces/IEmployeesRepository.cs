using ASPNet_API_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNet_API_Project.Repositories.Interfaces
{
    interface IEmployeesRepository
    {
        IEnumerable<Employees> Get();
        Task<Employees> Get(int id);
        int Create(Employees supplier);
        int Put(int id, Employees supplier);
    }
}
