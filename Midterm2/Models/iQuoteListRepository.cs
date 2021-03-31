using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2.Models
{
    public class iQuoteListRepository
    {
            IQueryable<Quote> Quotes { get; }
    }
}
