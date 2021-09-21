using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OglasnikItProekt.Models
{
    public class DbMob : DbContext
    {
        public DbSet<Mobilen> mobs { get; set; }
    }
}