using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class QuoteService
    {
        public List<QuoteDTO> GetAllQuotes()
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            QuoteDTO quoteDTO = new QuoteDTO(2, "MT-0623", "REF-2305", 5, new DateTime(), true, 5);
            quotesDTO.Add(quoteDTO);
            return quotesDTO;
        }
    }
}
