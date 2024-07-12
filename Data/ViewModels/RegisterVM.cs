using System.ComponentModel.DataAnnotations;

namespace FilmTicketShop.Data.ViewModels
{
	public class RegisterVM
	{
		[Display(Name = "Imię i Nazwisko")]
		[Required(ErrorMessage = "Imię i Nazwisko jest wymagany")]
		public string FullName { get; set; }

		[Display(Name ="Adres Email")]
		[Required(ErrorMessage = "Adres email jest wymagany")]
		public string EmailAddress { get; set; }

		[Display(Name = "Hasło")]
		[Required(ErrorMessage = "Hasło jest wymagane")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Potwierdź Hasło")]
		[Required(ErrorMessage = "Musisz potwierdzić hasło")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Hasło musi być takie samo")]
		public string ConfirmPassword { get; set; }

	}
}
