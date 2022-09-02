using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eKino.Services.Database
{
    public partial class eKinoContext : DbContext
    {
        public eKinoContext()
        {
        }

        public eKinoContext(DbContextOptions<eKinoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auditorium> Auditorium { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MovieGenre> MovieGenres { get; set; } = null!;
        public virtual DbSet<Projection> Projections { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=eKino; Trusted_Connection=yes; user=sa; Password=QWElkj132!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
