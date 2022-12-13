using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab_01.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "last Name")]
        public string LastName { get; set; }

        
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }


    }
}
