using System;
using System.Collections.Generic;
using System.Text;

namespace SharedData.Models
{
    public class GameResult
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
