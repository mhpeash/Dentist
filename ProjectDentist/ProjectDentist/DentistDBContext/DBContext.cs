using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectDentist.Models;


namespace ProjectDentist.DentistDBContext
{
    public class DBContext:DbContext

    {
        public DbSet<Registration> Registrations { get; set; }
    }
}