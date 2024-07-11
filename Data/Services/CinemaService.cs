using FilmTicketShop.Data.Base;
using FilmTicketShop.Models;

namespace FilmTicketShop.Data.Services
{
	public class CinemaService:EntityBaseRepository<Cinema>, ICinemasService
	{
		public CinemaService(AppDbContext context) : base(context) { }
	}
}
