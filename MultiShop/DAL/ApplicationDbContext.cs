﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using MultiShop.Models;

namespace MultiShop.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DressInformation> DressInformations { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?))
                )
            {
                item.SetColumnType("decimal(6,2)");
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Setting>()
                .HasIndex(p => p.Key)
                .IsUnique();
        }
    }
}
