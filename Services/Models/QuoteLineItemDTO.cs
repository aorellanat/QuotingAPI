using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class QuoteLineItemDTO
    {
        public string QuoteName { get; set; }
        public string ProductCode { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
