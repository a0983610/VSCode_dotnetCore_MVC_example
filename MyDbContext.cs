using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Program1.Models;

namespace Program1
{
    public class MyDbContext : DbContext
    {
        public DbSet<Member2> Member2 { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MYDB;Persist Security Info=True;User ID=test;Password=test");
        }
    }
}