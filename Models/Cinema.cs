using FilmTicketShop.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Models
{
	public class Cinema:IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "URL Loga")]
        [Required(ErrorMessage = "Wymagane Zdjęcie Kina")]
        public string? LogoURL { get; set; }

		[Display(Name = "Nazwa Kina")]
        [Required(ErrorMessage = "Wymagana Nazwa Kina")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mimimum 3 znaki maxiumum 50")]
        public string? Name { get; set; }
		
		[Display(Name = "Opis Kina")]
        [Required(ErrorMessage = "Wymagany Opis Kina")]
        public string? Description { get; set; }

		//Relationship

		public List<Movie>? Movies { get; set; }
	}
}
