using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ErecrTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String UserId { get; set; }
        [Required(ErrorMessage = "Please write your Family name")]
        public string FamilyName { get; set; }
        [Required(ErrorMessage = "Please write your First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please write your age")]
        public int Age { get; set; }
    }
}
