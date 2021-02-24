using ASPNet_API_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.ViewModels
{
    public class Register
    {
        public List<Employees> employees { get; set; }
        public List<Accounts> accounts { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Password)]
        public string AccountPassword { get; set; }
    }
}