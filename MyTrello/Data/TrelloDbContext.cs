using Microsoft.EntityFrameworkCore;
using MyTrello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Data
{
    public class TrelloDbContext : DbContext
    {
        public TrelloDbContext(DbContextOptions<TrelloDbContext> options)
            : base(options)
        {
        }

        public DbSet<TrelloBoard> Board { get; set; }
        public DbSet<TrelloTaskList> TaskList { get; set; }
        public DbSet<TrelloTask> Task { get; set; }
    }
}
