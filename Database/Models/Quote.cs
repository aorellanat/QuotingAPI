using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    class Quote
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public string IdProducts { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public bool Sold { get; set; }
        public int Quantity { get; set; }
    }
}
