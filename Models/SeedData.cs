using Microsoft.EntityFrameworkCore;
using RajPortfolio.Data;

namespace RajPortfolio.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RajPortfolioContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RajPortfolioContext>>()))
        {
            if (context == null || context.Track == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Track.Any())
            {
                return;   // DB has been seeded
            }

            context.Track.AddRange(
                new Track
                {
                    Title = "Pulse X",
                    length = 4.25
                },

                new Track
                {
                    Title = "Jungle",
                    length = 5.23
                },

                new Track
                {
                    Title = "Honey",
                    length = 6.11
                },

                new Track
                {
                    Title = "Rio Bravo",
                    length = 8.33
                }
            );
            context.SaveChanges();
        }
    }
}