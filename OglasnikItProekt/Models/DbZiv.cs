using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class DbZiv : DbContext
    {
        public DbSet<Zivealiste> zivs { get; set; }

    }
}