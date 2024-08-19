using API.Models;
using Microsoft.EntityFrameworkCore;
namespace API.Models
{
    public class Context : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Home_visit> Home_visits { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialization>().HasData(
                new Specialization { Id = 1, Name = "Cardiology" },
                new Specialization { Id = 2, Name = "Dermatology" },
                new Specialization { Id = 3, Name = "Endocrinology" },
                 new Specialization { Id = 4, Name = "Gastroenterology" },
                  new Specialization { Id = 5, Name = "Neurology" }


            );
            base.OnModelCreating(modelBuilder);
        }
    }
}


