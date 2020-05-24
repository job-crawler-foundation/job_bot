using JobBot.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobBot.Data
{
    public class JobBotDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public JobBotDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Default configuring method
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}
