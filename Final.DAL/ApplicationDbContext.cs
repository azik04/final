﻿using Final.Domain.Entity;
using Microsoft.EntityFrameworkCore;
namespace Final.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderTime> OrderTimes { get; set; }

    public DbSet<Stadium> Stadiums { get; set; }

}
