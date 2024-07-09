using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajPortfolio.Data;
using RajPortfolio.Models;

namespace RajPortfolio.Pages.Tracks
{
    public class IndexModel : PageModel
    {
        private readonly RajPortfolio.Data.RajPortfolioContext _context;

        public IndexModel(RajPortfolio.Data.RajPortfolioContext context)
        {
            _context = context;
        }

        public IList<Track> Track { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Track = await _context.Track.ToListAsync();
        }
    }
}
