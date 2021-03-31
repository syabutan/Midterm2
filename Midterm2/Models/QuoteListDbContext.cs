using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2.Models
{
    public class QuoteListDbContext : DbContext
    {
        public QuoteListDbContext(DbContextOptions<QuoteListDbContext> options) : base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
    }
}
