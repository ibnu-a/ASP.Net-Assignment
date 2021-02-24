using ASPNet_API_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNet_API_Project.myContext
{
    public class myContext : DbContext
    {
        public myContext() : base("myConnection") { }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Accounts> accounts { get; set; }

        public System.Data.Entity.DbSet<Api.ViewModels.Register> Registers { get; set; }
    }
}