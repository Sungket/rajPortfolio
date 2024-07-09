using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Titles { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? TrackTitle { get; set; }

        public async Task OnGetAsync()
        {
            var tracks = from t in _context.Track
                            select t;
            if (!string.IsNullOrEmpty(SearchString))
            {
                tracks = tracks.Where(s => s.Title.Contains(SearchString));
            }

            Track = await tracks.ToListAsync();
        }
    }
}
