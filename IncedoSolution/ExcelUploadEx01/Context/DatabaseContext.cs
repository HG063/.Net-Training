using ExcelUploadEx01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx01.Context
{
    public class DatabaseContext : DbContext
    {
        // public string cs1 = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=StarAppDB";
        // Data Source = G1 - 443HZH3-L\SQLEXPRESS;Initial Catalog = StarAppDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        public DatabaseContext()
            {
            }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string cs = string.Format("Data Source=G1-443HZH3-L\\SQLEXPRESS;Initial Catalog=StarAppDB;Integrated Security=True");
                options.UseSqlServer(cs);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Star> Stars { get; set; }
    }
}
