using FilmTicketShop.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Models
{
	public class Actor:IEntityBase
	{
		[Key]

		public int Id { get; set; }

		[Display(Name = "Zdjęcie aktora")]
		[Required(ErrorMessage ="Wmagane zdjęcie Aktora")]
		public string? ProfilePictureURL { get; set; }

		[Display(Name = "Imię i Nazwisko")]
		[Required(ErrorMessage ="Wymagane imię i nazwisko Aktora")]
		[StringLength (50, MinimumLength = 3, ErrorMessage ="Mimimum 3 znaki maxiumum 50")]
		public string? FullName { get; set; }

		[Display(Name = "Biografia")]
        [Required(ErrorMessage = "Wymagana Biografia")]
        public string? Bio { get; set; }

		//Relationship
		public List<Actor_Movie>? Actors_Movies { get; set; }

	}
}
