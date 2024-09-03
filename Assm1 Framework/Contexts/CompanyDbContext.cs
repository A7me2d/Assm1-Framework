using Assm1_Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_Framework.Contexts
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>(E =>
            {

                    E.Property(E => E.Id)
                    .UseIdentityColumn(1, 1);

                    E.Property(E => E.Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .HasDefaultValue("Ahmed");

                   E.Property(E => E.Salary)
                    .HasColumnType("money");

                   E.Property("Address")
                    .HasMaxLength(50)
                    .HasDefaultValue("Cairo");
            });

            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.EmpId)
            //    .UseIdentityColumn(1,1);

            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Name)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .HasDefaultValue("Ahmed");

            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Salary)
            //    .HasColumnType("money");

            //modelBuilder.Entity<Employee>()
            //    .Property("Address")
            //    .HasMaxLength(50)
            //    .HasDefaultValue("Cairo");


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}   