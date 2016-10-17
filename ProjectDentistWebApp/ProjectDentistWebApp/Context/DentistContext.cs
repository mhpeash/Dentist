using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectDentistWebApp.Models;

namespace ProjectDentistWebApp.Context
{
    public class DentistContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}