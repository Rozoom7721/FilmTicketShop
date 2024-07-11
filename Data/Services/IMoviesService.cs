using FilmTicketShop.Data.Base;
using FilmTicketShop.Data.ViewModels;
using FilmTicketShop.Models;

namespace FilmTicketShop.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();


        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
