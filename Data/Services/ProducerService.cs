using FilmTicketShop.Data.Base;
using FilmTicketShop.Models;

namespace FilmTicketShop.Data.Services
{
	public class ProducerService: EntityBaseRepository<Producer>, IProducerService
	{
		public ProducerService(AppDbContext context) :base(context) { }
	}
}
