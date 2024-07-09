using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RajPortfolio.Models;

namespace RajPortfolio.Data
{
    public class RajPortfolioContext : DbContext
    {
        public RajPortfolioContext (DbContextOptions<RajPortfolioContext> options)
            : base(options)
        {
        }

        public DbSet<RajPortfolio.Models.Track> Track { get; set; } = default!;
    }
}
