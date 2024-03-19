using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BBFlix.Models.EF
{
    public partial class BBFlixContext : DbContext
    {
        public BBFlixContext()
            : base("name=BBFlixContext")
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieCast> MovieCast { get; set; }
        public virtual DbSet<MovieData> MovieData { get; set; }
        public virtual DbSet<MovieDirection> MovieDirection { get; set; }
        public virtual DbSet<MovieGenres> MovieGenres { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Reviewer> Reviewer { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .HasMany(e => e.MovieCast)
                .WithRequired(e => e.Actor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Movie)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.mov_country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Director>()
                .HasMany(e => e.MovieDirection)
                .WithRequired(e => e.Director)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genres>()
                .HasMany(e => e.MovieGenres)
                .WithRequired(e => e.Genres)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieCast)
                .WithRequired(e => e.Movie)
                .HasForeignKey(e => e.movie_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieData)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieDirection)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieGenres)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Reviewer)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Plan)
                .HasForeignKey(e => e.user_plan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reviewer)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.rev_by)
                .WillCascadeOnDelete(false);
        }
    }
}
