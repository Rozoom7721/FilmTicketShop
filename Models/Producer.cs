using FilmTicketShop.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Models
{
	public class Producer:IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "Zdjęcie Reżysera")]
        [Required(ErrorMessage = "Wmagane zdjęcie Reżysera")]
        public string? ProfilePictureURL { get; set; }

		[Display(Name = "Imię i nazwisko")]
        [Required(ErrorMessage = "Wymagane imię i nazwisko Reżysera")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mimimum 3 znaki maxiumum 50")]
        public string? FullName { get; set; }

		[Display(Name = "Biografia")]
        [Required(ErrorMessage = "Wymagana Biografia")]
        public string? Bio { get; set; }

		//Relationship

		public List<Movie>? Movies { get; set; }
	}
}
