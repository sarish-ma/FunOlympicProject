using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FunOlympicProject.Models
{
    public class ApplicationUser: IdentityUser
    {


        [MaxLength(50, ErrorMessage = "Only 80 characters are valid.")]
        public string FullName { get; set; }
        [MaxLength(50, ErrorMessage = "Only 80 characters are valid.")]

        public string City { get; set; }
        [MaxLength(50, ErrorMessage = "Only 80 characters are valid.")]

        public String Country { get; set; }
        public DateTime DOB { get; set; }

    }
}
