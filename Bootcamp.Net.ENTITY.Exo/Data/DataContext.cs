﻿using Bootcamp.Net.ENTITY.Exo.Data.Config;
using Bootcamp.Net.ENTITY.Exo.Data.DataSet;
using Bootcamp.Net.ENTITY.Exo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Net.ENTITY.Exo.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Film> Films { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<FilmPersonne> FilmPersonnes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new FilmPersonneConfig());

            modelBuilder.ApplyConfiguration(new FilmData());
            modelBuilder.ApplyConfiguration(new PersonneData());
            modelBuilder.ApplyConfiguration(new FilmPersonneData());
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_ENTITY_BOOTCAMP_NET;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
