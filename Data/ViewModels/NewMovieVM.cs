using FilmTicketShop.Data.Base;
using FilmTicketShop.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmTicketShop.Models
{
    public class NewMovieVM
	{
        public int Id { get; set; }

        [Display(Name = "Tytuł Filmu")]
        [Required (ErrorMessage ="Podaj tytuł filmu")]

		public string? Title { get; set; }

        [Display(Name = "Opis Filmu")]
        [Required(ErrorMessage = "Podaj opis filmu")]

        public string? Description { get; set; }

        [Display(Name = "Cena Filmu")]
        [Required(ErrorMessage = "Podaj cene filmu")]

        public double Price { get; set; }

        [Display(Name = "Zdjęcie Filmu")]
        [Required(ErrorMessage = "Podaj URl do zdjęcia filmu")]

        public string? ImageURL { get; set; }

        [Display(Name = "Data Rozpoczęcia Filmu")]
        [Required(ErrorMessage = "Podaj date rozpoczęcia filmu")]

        public DateTime StartDate { get; set; }

        [Display(Name = "Data Zakończenia Filmu")]
        [Required(ErrorMessage = "Podaj date zakończenia filmu")]

        public DateTime EndDate { get; set; }

        [Display(Name = "Kategoria Filmu")]
        [Required(ErrorMessage = "Podaj kategorie filmu ")]

        public MovieCategory MovieCategory { get; set; }

        //Relationship
        [Display(Name = "Aktorzy filmu")]
        [Required(ErrorMessage = "Wybierz aktorów grających w filmie")]

        public List<int>? ActorsIds{ get; set; }

        [Display(Name = "Kino Filmu")]
        [Required(ErrorMessage = "Podaj kino w którym puszczany jest film")]

        public int CinemaId { get; set; }

        [Display(Name = "Reżyser Filmu")]
        [Required(ErrorMessage = "Podaj Reżysera filmu")]

        public int ProducerId { get; set; }

	}
}
