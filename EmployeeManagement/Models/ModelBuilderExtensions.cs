using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Magesh1",
                   Department = Dept.IT,
                   Email = "magesh1@gmail.com"

               },
               new Employee
               {
                   Id = 2,
                   Name = "Janu",
                   Department = Dept.HR,
                   Email = "Janu@gmail.com"

               }
          );
        }
    }
}
