using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SledgeRental.Data.Models;
using SledgeRental.Data.Models.Views;

namespace SledgeRental.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Sledge> Sledges { get; set; }

        public DbSet<SledgeKind> SledgeKinds { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
        
        public DbSet<ReservationInfo> ReservationInfos { get; set; }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=MARTINPC\\SQLEXPRESS;Initial Catalog=SledgeRentalDb; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");


        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<SledgeKind>().HasData(
                new SledgeKind()
                {
                    Id = 1,
                    Name = "Einsitzer",
                },
                new SledgeKind()
                {
                    Id = 2,
                    Name = "Zweisitzer",
                },
                new SledgeKind()
                {
                    Id = 3,
                    Name = "Rennschlitten",
                });


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "1",
                    Name = "Staff",
                    NormalizedName = "STAFF",
                    ConcurrencyStamp = "1"
                });

            builder.Entity<ReservationInfo>()
                .ToView("RegistrationInfo_View");

            base.OnModelCreating(builder);
        }


    }
}
