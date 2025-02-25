namespace Infrastructure;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using static Infrastructure.AppDbContext;

public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Users> Users { get; set; }
    public DbSet<Movies> Movies { get; set; }
    public DbSet<Genres> genres { get; set; }
    public DbSet<Movie_genres> Movie_genres { get; set; }
    public DbSet<RelatedMovies> RelatedMovies { get; set; }
    public DbSet<Favorites> Favorites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
  

 }

