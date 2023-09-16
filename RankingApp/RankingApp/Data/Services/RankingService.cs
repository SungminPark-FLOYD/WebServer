using RankingApp.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankingApp.Data.Services
{
    public class RankingService
    {
        ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<GameResult>> GetGameResultsAsync()
        {
            List<GameResult> results = _context.GameResules
                                    .OrderByDescending(item => item.Score).ToList();

            return Task.FromResult(results);
        }
    }
}
