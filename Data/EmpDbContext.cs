using EmployeeManagementSystem.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class EmpDbContext: DbContext
    {
        public EmpDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
