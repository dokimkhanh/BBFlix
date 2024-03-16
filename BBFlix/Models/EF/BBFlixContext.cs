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
            modelBuilder.Entity<Country>()
                .HasMany(e => e.Movie)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.mov_country);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieCast)
                .WithOptional(e => e.Movie)
                .HasForeignKey(e => e.movie_id);

            modelBuilder.Entity<Plan>()
                .HasMany(e => e.User)
                .WithOptional(e => e.Plan)
                .HasForeignKey(e => e.user_plan);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reviewer)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.rev_by);
        }
    }
}
