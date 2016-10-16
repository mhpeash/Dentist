using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DentistProject.Models;

namespace DentistProject.Context
{
    public class DentistContext:DbContext
    {
        public DbSet<Registration> Registration { get; set; }

    }
}