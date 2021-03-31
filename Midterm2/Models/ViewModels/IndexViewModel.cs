using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Quote> Quotes { get; set; }
        public string CurrentQuote { get; set; }
    }
}
