using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SledgeRental.Data.Models;

namespace SledgeRental.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Sledge> Sledges { get; set; }

        public DbSet<SledgeKind> SledgeKinds { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
