using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class DbBT : DbContext
    {
        public DbSet<BelaTehnika> bts { get; set; }

    }
}