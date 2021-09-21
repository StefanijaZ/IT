using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class DbAvto : DbContext
    {
        public DbSet<Avtomobil> avtos { get; set; }

    }
}