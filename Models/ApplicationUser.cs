using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name ="Imię i nazwisko")]
        public string FullName { get; set; }
    }
}
