using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class QuoteService:IQuoteService
    {
        public List<QuoteDTO> GetAll()
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO = new QuoteLineItemDTO
            {
                QuoteName = "COT-01",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItemDTOs.Add(quoteLineItemDTO);

            QuoteDTO quoteDTO = new QuoteDTO
            {
                QuoteName = "COT-01",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItemDTOs
            };

            quotesDTO.Add(quoteDTO);

            return quotesDTO;
        }

        public QuoteDTO GetQuoteByname(string quoteName)
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs1 = new List<QuoteLineItemDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs2 = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO1 = new QuoteLineItemDTO
            {
                QuoteName = "COT-01",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };
           
            quoteLineItemDTOs1.Add(quoteLineItemDTO1);

            QuoteLineItemDTO quoteLineItemDTO2 = new QuoteLineItemDTO
            {
                QuoteName = "COT-02",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItemDTOs2.Add(quoteLineItemDTO2);

            QuoteDTO quoteDTO1 = new QuoteDTO
            {
                QuoteName = "COT-01",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItemDTOs1
            };

            QuoteDTO quoteDTO2 = new QuoteDTO
            {
                QuoteName = "COT-02",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItemDTOs2
            };

            quotesDTO.Add(quoteDTO1);
            quotesDTO.Add(quoteDTO2);

            foreach (QuoteDTO quote in quotesDTO)
            {
                if (quote.QuoteName.Equals(quoteName))
                {
                    return quote;
                }
            }

            return null;

        }

        public void PostQuote(QuoteDTO newQuoteDTO)
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs1 = new List<QuoteLineItemDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs2 = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO1 = new QuoteLineItemDTO
            {
                QuoteName = "COT-01",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItemDTOs1.Add(quoteLineItemDTO1);

            QuoteLineItemDTO quoteLineItemDTO2 = new QuoteLineItemDTO
            {
                QuoteName = "COT-02",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItemDTOs2.Add(quoteLineItemDTO2);

            QuoteDTO quoteDTO1 = new QuoteDTO
            {
                QuoteName = "COT-01",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItemDTOs1
            };

            QuoteDTO quoteDTO2 = new QuoteDTO
            {
                QuoteName = "COT-02",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItemDTOs2
            };

            quotesDTO.Add(quoteDTO1);
            quotesDTO.Add(quoteDTO2);
            quotesDTO.Add(newQuoteDTO);

        }

        public void UpdateByName(string quoteName, QuoteDTO quoteUpdated)
        {
            List<QuoteDTO> quotes = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItems = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItem = new QuoteLineItemDTO
            {
                QuoteName = "COT-01",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItems.Add(quoteLineItem);

            QuoteDTO quote1 = new QuoteDTO
            {
                QuoteName = "COT-01",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItems
            };
            QuoteDTO quote2 = new QuoteDTO
            {
                QuoteName = "COT-03",
                ClientCode = "MTR-300095",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItems
            };

            quotes.Add(quote1);
            quotes.Add(quote2);

            int index = quotes.IndexOf(quotes.Find(quote => quote.QuoteName.Equals(quoteName)));
            quotes[index] = quoteUpdated;
        }

        public void DeleteByName(string quoteName)
        {
            List<QuoteDTO> quotes = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItems = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItem = new QuoteLineItemDTO
            {
                QuoteName = "COT-01",
                ProductCode = "EMP-000001",
                Price = 5,
                Quantity = 10
            };

            quoteLineItems.Add(quoteLineItem);

            QuoteDTO quote1 = new QuoteDTO
            {
                QuoteName = "COT-01",
                ClientCode = "MTR-300065",
                Date = new DateTime(),
                Sold = true,
                QuoteLineItems = quoteLineItems
            };

            quotes.Add(quote1);

            quotes.RemoveAll(quote => quote.QuoteName.Equals(quoteName));
        }
    }
}
