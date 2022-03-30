using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueDbContext _context { get; set; }

        public EFBowlingLeagueRepository (BowlingLeagueDbContext temp)
        {
            _context = temp;
        }

        public IQueryable<Recipe> Recipes => _context.Recipes;
    }
}
