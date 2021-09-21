using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class DbLaptop : DbContext
    {
        public DbSet<Laptop> laps { get; set; }

    }
}