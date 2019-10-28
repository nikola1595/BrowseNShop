using BrowseNShop.Interfaces;
using BrowseNShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Data.Repositories
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly ApplicationDbContext _context;
        public SneakerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sneaker> Sneakers => _context.Sneakers.Include(c => c.Category);

        public IEnumerable<Sneaker> PreferredSneakers => _context.Sneakers.Where(p => p.IsPreferred).Include(c => c.Category);

        public Sneaker GetSneakerById(int sneakerID) => _context.Sneakers.FirstOrDefault(p => p.SneakerID == sneakerID);
    }
}
