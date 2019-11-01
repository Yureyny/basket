using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace tbasket.Models
{
    public class tbasketContext : DbContext
    {
        public tbasketContext() : base("name=basket")
        {

        }
        public DbSet<Division> Division
        {
            get; set;
        }

        public DbSet<Equipo> Equipo

        { get; set; }

    }
}