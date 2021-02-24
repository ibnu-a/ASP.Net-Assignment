using Api.ViewModels;
using ASPNet_API_Project.Repositories.Interfaces;
//using ASPNet_API_Project.ViewModels;
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
    public class AccountsRepository : IAccountsRepository
    {
        DynamicParameters parameters = new DynamicParameters();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
        public async Task<IEnumerable<Register>> Post(Register register)
        {
            var SP_Net = "SP_login";
            parameters.Add("@EmailAddress", register.EmailAddress);
            parameters.Add("@Password", register.AccountPassword);
            var result = await connection.QueryAsync<Register>(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int Create(Register register)
        {
            var SP_Net = "SP_insertData";
            parameters.Add("@Name", register.Name);
            parameters.Add("@EmailAddress", register.EmailAddress);
            parameters.Add("@Phone", register.Phone);
            parameters.Add("@Address", register.Address);
            parameters.Add("@Password", register.AccountPassword);
            //nama setelah @ sesuaikan dengan yang ada di SP

            var result = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int Delete(int id)
        {
            var SP_Net = "SP_deleteRegister";
            parameters.Add("@Id", id);
            var result = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Register> Get(int id)
        {
            var SP_Net = "SP_retriveRegister";
            parameters.Add("@Id", id);
            var result = await connection.QueryAsync<Register>(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public int Update(int Id, Register register)
        {
            var SP_Net = "SP_updateSupplier";
            parameters.Add("@Id", Id);
            parameters.Add("@Name", register.Name);
            parameters.Add("@EmailAddress", register.EmailAddress);
            parameters.Add("@Phone", register.Phone);
            parameters.Add("@Address", register.Address);
            parameters.Add("@Password", register.AccountPassword);

            var result = connection.Execute(SP_Net, parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Register> Login()
        {
            var SP_Net = "SP_retriveAllData";
            var GetAll = connection.Query<Register>(SP_Net, commandType: CommandType.StoredProcedure);
            return GetAll; 
        }

       
    }
}