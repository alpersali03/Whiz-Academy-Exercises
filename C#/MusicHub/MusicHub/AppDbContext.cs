using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    internal class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AUT50J3;Database=Music;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        DbSet<Writer> Writers { get; set; }
        DbSet<Performer> Performers { get; set; }   
        DbSet<Producer> Producers { get; set; }
        DbSet<Album> Albums { get; set; }
        DbSet<Song> Songs { get; set; }
        DbSet<SongsPerformer> SongsPerformers { get; set;}


    }
}
