using ASPNet_API_Project.Models;
using ASPNet_API_Project.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASPNet_API_Project.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        DynamicParameters parameters = new DynamicParameters();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);

        public int Create(Employees supplier)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> Get()
        {
            var SP_Net = "SP_retriveAllData";
            var GetAll = connection.Query<Employees>(SP_Net, commandType: CommandType.StoredProcedure);
            return GetAll;
        }

        public Task<Employees> Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Put(int id, Employees supplier)
        {
            throw new NotImplementedException();
        }
    }
}