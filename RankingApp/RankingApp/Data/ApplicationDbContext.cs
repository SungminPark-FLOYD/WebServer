using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RankingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RankingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GameResult> GameResules { get; set; }  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
