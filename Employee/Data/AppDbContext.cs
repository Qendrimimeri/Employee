﻿using Employee.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    public DbSet<Models.Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
}
