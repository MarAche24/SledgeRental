using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SledgeRental.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool IsStaff { get; set; } = false;

        [StringLength(256)]
        public string FirstName { get; set; } = null!;

        [StringLength(256)]
        public string LastName { get; set; } = null!;
    }
}
