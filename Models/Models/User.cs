using DataAnnotationsExtensions;
using Microsoft.AspNetCore.Identity;
using Models.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User :IdentityUser
    {
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pin is required")]
        public int Pin { get; set; }

        [Compare("Pin", ErrorMessage ="Pin does not match")]
        public int ConfirmPin { get; set; }

        public List<CheckingAccount> CheckingAccounts { get; set; }

    }
}
