using FilmTicketShop.Data;
using FilmTicketShop.Data.Services;
using FilmTicketShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FilmTicketShop.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMoviesService _service;

		public MoviesController(IMoviesService service)
		{
			_service = service;
		}
		public async Task<IActionResult> Index()
		{
			var allMovies = await _service.GetAllAsync(n => n.Cinema);
			return View(allMovies);
		}

		//GET: Movie/Details/1

		public async Task<IActionResult> Details(int id)
		{
			var movieDetail = await _service.GetMovieByIdAsync(id);
			return View(movieDetail);
		}
        //GET: Movie/Create

        public async Task<IActionResult> Create()
        {
			var movieDropdownData = await _service.GetNewMovieDropdownsValues();

			ViewBag.CinemaId = new SelectList(movieDropdownData.Cinemas, "Id", "Name");
            ViewBag.ProducerId = new SelectList(movieDropdownData.Producers, "Id", "FullName");
            ViewBag.ActorId = new SelectList(movieDropdownData.Actors, "Id", "FullName");

			return View();
        }

		[HttpPost]
		
		public async Task<IActionResult> Create(NewMovieVM movie)
		{
			if (!ModelState.IsValid)
			{
                var movieDropdownData = await _service.GetNewMovieDropdownsValues();
                ViewBag.CinemaId = new SelectList(movieDropdownData.Cinemas, "Id", "Name");
                ViewBag.ProducerId = new SelectList(movieDropdownData.Producers, "Id", "FullName");
                ViewBag.ActorId = new SelectList(movieDropdownData.Actors, "Id", "FullName");
                return View(movie);
			}
			await _service.AddNewMovieAsync(movie);

			return RedirectToAction("Index");
		}
        //GET: Movie/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Title = movieDetails.Title,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.MovieCategory,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                ActorsIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList(),
            };
            var movieDropdownData = await _service.GetNewMovieDropdownsValues();
            ViewBag.CinemaId = new SelectList(movieDropdownData.Cinemas, "Id", "Name");
            ViewBag.ProducerId = new SelectList(movieDropdownData.Producers, "Id", "FullName");
            ViewBag.ActorId = new SelectList(movieDropdownData.Actors, "Id", "FullName");
            return View(response);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id,NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownData = await _service.GetNewMovieDropdownsValues();
                ViewBag.CinemaId = new SelectList(movieDropdownData.Cinemas, "Id", "Name");
                ViewBag.ProducerId = new SelectList(movieDropdownData.Producers, "Id", "FullName");
                ViewBag.ActorId = new SelectList(movieDropdownData.Actors, "Id", "FullName");
                return View(movie);
            }
            await _service.UpdateMovieAsync(movie);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);

            if(!string.IsNullOrEmpty(searchString))
            {
                var filtredResult = allMovies.Where(n => n.Title.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filtredResult);
            }    

            return View("Index", allMovies);
        }

    }
}
