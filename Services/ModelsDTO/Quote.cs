using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Quote
    {
        public string QuoteName { get; set; }
        public string ClientCode { get; set; }
        public DateTime Date { get; set; }
        public bool Sold { get; set; }
        public List<QuoteLineItem> QuoteLineItems { get; set; }
    }
}
