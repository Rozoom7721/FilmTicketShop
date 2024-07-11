using FilmTicketShop.Data;
using FilmTicketShop.Data.Services;
using FilmTicketShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmTicketShop.Controllers
{
	public class CinemasController : Controller
	{
		private readonly ICinemasService _service;

			public CinemasController(ICinemasService service)
			{
				_service = service;
			}
		public async Task<IActionResult> Index()
		{
			var allCinemas = await _service.GetAllAsync();
			return View(allCinemas);
		}

		//GET: Cinemas/Create

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create([Bind("LogoURL,Name,Description")] Cinema cinema)
		{
			if (!ModelState.IsValid) return View(cinema);
			await _service.AddAsync(cinema);
			return RedirectToAction("Index");
		}

        //GET: Cinemas/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
			if (cinemaDetails == null) return View("NotFound");
			return View(cinemaDetails);
        }
        //GET: Cinemas/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,LogoURL,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.UpdateAsync(id,cinema);
            return RedirectToAction("Index");
        }
		//GET: Cinemas/Delete/1

		public async Task<IActionResult> Delete(int id)
		{
			var cinemaDetails = await _service.GetByIdAsync(id);
			if (cinemaDetails == null) return View("NotFound");
			return View(cinemaDetails);
		}
		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirm(int id)
		{
			var cinemaDetails = await _service.GetByIdAsync(id);
			if (cinemaDetails == null) return View("NotFound");
			
			await _service.DeleteAsync(id);
			return RedirectToAction("Index");
		}
	}
}
