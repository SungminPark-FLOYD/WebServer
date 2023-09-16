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

        //Create
        public Task<GameResult> AddGameResult(GameResult gameResult)
        {
            _context.GameResules.Add(gameResult);
            _context.SaveChanges(); 

            return Task.FromResult(gameResult);
        }
        //Read
        public Task<List<GameResult>> GetGameResultsAsync()
        {
            List<GameResult> results = _context.GameResules
                                    .OrderByDescending(item => item.Score).ToList();

            return Task.FromResult(results);
        }

        //Update
        public Task<bool> UpdateGameResult(GameResult gameResult)
        {
            var findResult = _context.GameResules
                .Where(x => x.id == gameResult.id)
                .FirstOrDefault();

            if (findResult == null)
                return Task.FromResult(false);

            findResult.UserName = gameResult.UserName;
            findResult.Score = gameResult.Score;
            _context.SaveChanges();

            return Task.FromResult(true);
        }
        //Delete
        public Task<bool> DeleteGameResult(GameResult gameResult)
        {
            var findResult = _context.GameResules
                .Where(x => x.id == gameResult.id)
                .FirstOrDefault();

            if (findResult == null)
                return Task.FromResult(false);

            _context.GameResules.Remove(gameResult);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
