﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
