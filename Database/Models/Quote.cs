using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    class Quote
    {
        public string QuoteName { get; set; }
        public string ClientCode { get; set; }
        public DateTime Date { get; set; }
        public bool Sold { get; set; }
        public List<QuoteLineItem> QuoteLineItems { get; set; }
    }
}
