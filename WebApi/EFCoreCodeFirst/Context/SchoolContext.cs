using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; } //table students
        public DbSet<Grade> Grades { get; set; } //table grades
        public DbSet<Address> Addresss { get; set; } //table address

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Data Source=LONGNGUYENDH\\SQLEXPRESS;Initial Catalog=SchoolDB;User ID=sa;Password=Asdf@123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
