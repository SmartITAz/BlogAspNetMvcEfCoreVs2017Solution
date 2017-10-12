//Copyright 2017 (c) SmartIT. All rights reserved.
//By John Kocer
// This file is for Swagger test, this application does not use this file
using BlogUi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogUi.Ef
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options){}

    public DbSet<Blog> Blog { get; set; }
    public DbSet<Post> Post { get; set; }
  }
}