using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using WhoTrial.Entities;

namespace WhoTrial.Data
{
    public partial class IonicAppContext : DbContext
    {
        public IonicAppContext()
            : base("name=IonicAppContext")
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Data_Registration> Data_Registration { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Month> Month { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Hospital)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.Data_Registration)
                .WithRequired(e => e.Hospital)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Month>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<Month>()
                .HasMany(e => e.Data_Registration)
                .WithRequired(e => e.Month)
                .WillCascadeOnDelete(false);
        }
    }
}
