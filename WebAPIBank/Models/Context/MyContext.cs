using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Entites;
using WebAPIBank.Models.Init;

namespace WebAPIBank.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer(new MyInit());
        }
        public DbSet<CardInfo> Cards { get; set; }
    }
}