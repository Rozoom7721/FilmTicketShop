using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Data.ViewModels
{
	public class LoginVM
	{
		[Display(Name ="Adres Email")]
		[Required(ErrorMessage = "Adres email jest wymagany")]
		public string EmailAddress { get; set; }

		[Display(Name = "Hasło")]
		[Required(ErrorMessage = "Hasło jest wymagane")]
		[DataType(DataType.Password)]
		public string Password { get; set; }



	}
}
