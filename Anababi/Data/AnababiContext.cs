﻿using Anababi.ModelClasses;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Xml;

namespace Anababi.Data
{
    public class AnababiContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Reference> References { get; set; } = null!;
        public DbSet<PhysicalReference> PhysicalReferences { get; set; } = null!;
        public DbSet<DigitalReference> DigitalReferences { get; set; } = null!;
        public DbSet<PhysicalReference.ReferenceLocation> ReferenceLocations { get; set; }
        public DbSet<Library> Libraries { get; set; } = null!;
        public DbSet<Creator> Creators { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = 
                @"server = .; 
                database = AnababiLMS; 
                integrated security = true; 
                encrypt = false";
            optionsBuilder.UseSqlServer(connectionString);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property("Password")
                    .HasColumnName("Password")
                    .IsRequired(); 
            });
        }
    }
}
