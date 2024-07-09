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
    public class DeleteModel : PageModel
    {
        private readonly RajPortfolio.Data.RajPortfolioContext _context;

        public DeleteModel(RajPortfolio.Data.RajPortfolioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Track Track { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Track.FirstOrDefaultAsync(m => m.id == id);

            if (track == null)
            {
                return NotFound();
            }
            else
            {
                Track = track;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Track.FindAsync(id);
            if (track != null)
            {
                Track = track;
                _context.Track.Remove(Track);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
