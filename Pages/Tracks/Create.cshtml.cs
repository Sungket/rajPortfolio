using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RajPortfolio.Data;
using RajPortfolio.Models;

namespace RajPortfolio.Pages.Tracks
{
    public class CreateModel : PageModel
    {
        private readonly RajPortfolio.Data.RajPortfolioContext _context;

        public CreateModel(RajPortfolio.Data.RajPortfolioContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Track Track { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Track.Add(Track);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
