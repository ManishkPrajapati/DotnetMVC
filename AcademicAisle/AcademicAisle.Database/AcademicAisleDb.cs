using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AcademicAsile.entities;

namespace AcademicAisle.Database
{
    public class AcademicAisleDb: DbContext, IDisposable
    {
        public AcademicAisleDb(): base("AisleConnection")
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> MyProducts { get; set; }
    }
}
