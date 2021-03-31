using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2.Models
{
    public class EFQuoteRepository : iQuoteListRepository
    {
        private QuoteListDbContext _context;
        public EFQuoteRepository (QuoteListDbContext context)
        {
            _context = context;
        }
        public IQueryable<Quote> Quotes => _context.Quotes;
    }
}
