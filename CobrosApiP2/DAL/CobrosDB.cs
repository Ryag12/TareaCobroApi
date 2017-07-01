using CobrosApiP2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CobrosApiP2.DAL
{
    public class CobrosDB : DbContext
    {
        public CobrosDB() : base("ConStr")
        {

        }

        public DbSet<Cobros> Cobros { get; set; }
    }
}