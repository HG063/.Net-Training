using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp01
{
    public class EmpDemoDB : DbContext
    {
        public EmpDemoDB(DbContextOptions<EmpDemoDB>options) :base(options)
        {
        }
        public DbSet<EmpModel> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //To see data into the table
            modelBuilder.Entity<EmpModel>().HasData(
                new EmpModel { Id = 101, EName = "Harshit", Job = "Developer", Salary = 60000 },
                new EmpModel { Id = 102, EName = "Kiran", Job = "Trainer", Salary = 50000 }
                );
        }
    }
    //The following class to table within the database
    [Table("tblEmployees")]

    public class EmpModel
    {
        [Key]
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }

}
