using AcademicAsile.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AcademicAisle.Database
{
    public class AcademicAisleDb: DbContext
    {
        public AcademicAisleDb(): base("AisleConnection")
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> MyProducts { get; set; }
    }
}
