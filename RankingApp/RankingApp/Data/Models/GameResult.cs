﻿using System;

namespace RankingApp.Data.Models
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
