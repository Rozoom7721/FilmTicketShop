using FilmTicketShop.Models;

namespace FilmTicketShop.Data.Services
{
	public interface IOrdersService
	{

		Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);

		Task<List<Order>> GetOrdersByUserIdAsync(string userId);
	}
}
