﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OOAD_tutorijal_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_tutorijal_FINAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<UpisNaPredmet> UpisNaPredmet { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<UpisNaPredmet>().ToTable("UpisNaPredmet");
            modelBuilder.Entity<Predmet>().ToTable("Predmet");
            base.OnModelCreating(modelBuilder);
        }

    }
}
