using FilmTicketShop.Data.Base;
using FilmTicketShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace FilmTicketShop.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context) { }

    }
}
