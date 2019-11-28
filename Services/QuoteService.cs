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
            List<QuoteLineItemDTO> quoteLineItemDTOs = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO = new QuoteLineItemDTO("COT-01", "EMP-000001", 5, 10);
            quoteLineItemDTOs.Add(quoteLineItemDTO);

            QuoteDTO quoteDTO = new QuoteDTO("COT-01", "MTR-300065", new DateTime(), true, quoteLineItemDTOs);

            quotesDTO.Add(quoteDTO);

            return quotesDTO;
        }

        // GetQuoteByName()

        // UpdateQuote()

        // DeleteQuote()
    }
}
