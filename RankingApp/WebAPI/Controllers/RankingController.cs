using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;

namespace WebAPI.Controllers
{

    //REST
    //공식 표준 스펙은 아님
    //원래 있던 HTTP통신에서 기능을 재사용해서 데이터 송수신 규칙을 만든것

    //CRUD
    //Create / Read / Update / Delete

    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        ApplicationDbContext _context;

        public RankingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<GameResult> GetGameResults()
        {
            List<GameResult> results = _context.GameResults
                .OrderByDescending(item => item.Score)
                .ToList();

            return results;
        }

        [HttpGet("{id}")]
        public GameResult GetGameResults(int id)
        {
            GameResult results = _context.GameResults
                .Where(item => item.id == id)
                .FirstOrDefault();

            return results;
        }
    }
}
