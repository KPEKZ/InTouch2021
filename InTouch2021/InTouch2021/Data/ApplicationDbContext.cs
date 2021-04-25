using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InTouch2021.Models;

namespace InTouch2021.Data
{
    public class ApplicationDbContext : DbContext
    {
        private DbContextOptions<ApplicationDbContext> op;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.op = options;
        }

        public DbSet<AnketaFormDataModel> Items { get; set; }
        public DbSet<FeedBackModel> FeedBackItems { get; set; }
    }
}
