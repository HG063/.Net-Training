using ExcelUploadEx02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx02.Context
{
    public class DatabaseContext : DbContext
    {
        // public string cs1 = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=StarAppDB";
        // Data Source = G1 - 443HZH3-L\SQLEXPRESS;Initial Catalog = StarAppDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
                var cs = string.Format("Data Source=G1-443HZH3-L\\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True");
                options.UseSqlServer(cs);
        }
        

        public DbSet<Student> Students { get; set; }
    }
}
