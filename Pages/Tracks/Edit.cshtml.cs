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
    public class EditModel : PageModel
    {
        private readonly RajPortfolio.Data.RajPortfolioContext _context;

        public EditModel(RajPortfolio.Data.RajPortfolioContext context)
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

            var track =  await _context.Track.FirstOrDefaultAsync(m => m.id == id);
            if (track == null)
            {
                return NotFound();
            }
            Track = track;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Track).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackExists(Track.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrackExists(int id)
        {
            return _context.Track.Any(e => e.id == id);
        }
    }
}