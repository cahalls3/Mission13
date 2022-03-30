using System;
using Microsoft.EntityFrameworkCore;

namespace Mission13.Models
{
    public class BowlingLeagueDbContext : DbContext
    {
        public BowlingLeagueDbContext(DbContextOptions<BowlingLeagueDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
