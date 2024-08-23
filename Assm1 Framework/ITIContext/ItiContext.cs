using Assm1_Framework.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_Framework.ITIContext
{
    internal class ItiContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>(s =>
            { 
                s.HasKey(s => s.Stud_Id);   

                s.Property(s => s.GPA )
                .HasColumnType("int");
            });

            modelBuilder.Entity<Department>(d => 
            {
                d.Property(d => d.Id)
                                   .UseIdentityColumn(1, 1);
            });

            modelBuilder.Entity<Instructor>(I => 
            {
                I.Property(i => i.Id)
                                                   .UseIdentityColumn(1, 1);
            });
                        
                            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics  { get; set; }
        public DbSet<Course_inst> Course_Insts { get; set; }
        public DbSet<Course_inst> Course_insts { get; set; }

    }
}
