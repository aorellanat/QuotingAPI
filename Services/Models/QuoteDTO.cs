using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class QuoteDTO
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public string IdProducts { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public bool Sold { get; set; }
        public int Quantity { get; set; }

        public QuoteDTO(int id, string idClient, string idProducts, float price, DateTime date, bool sold, int quantity)
        {
            Id = id;
            IdClient = idClient;
            IdProducts = idProducts;
            Price = price;
            Date = date;
            Sold = sold;
            Quantity = quantity;
        }
    }
}
