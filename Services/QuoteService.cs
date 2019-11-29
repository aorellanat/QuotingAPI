using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class QuoteService:IQuoteService
    {
        public List<QuoteDTO> GetAllQuotes()
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO = new QuoteLineItemDTO(
                quoteName: "COT-01",
                productCode:"EMP-000001", 
                price: 5,
                quantity: 10);
            quoteLineItemDTOs.Add(quoteLineItemDTO);

            QuoteDTO quoteDTO = new QuoteDTO(
                quoteName: "COT-01", 
                clientCode: "MTR-300065",
                date: new DateTime(), 
                sold: true,
                quoteLineItemDTOs: quoteLineItemDTOs);

            quotesDTO.Add(quoteDTO);

            return quotesDTO;
        }

        public QuoteDTO GetQuotebyname(string QuoteName)
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs1 = new List<QuoteLineItemDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs2 = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO1 = new QuoteLineItemDTO(
                quoteName: "COT-01",
                productCode: "EMP-000001",
                price: 5,
                quantity: 10);
           
            quoteLineItemDTOs1.Add(quoteLineItemDTO1);

            QuoteLineItemDTO quoteLineItemDTO2 = new QuoteLineItemDTO(
                quoteName: "COT-02",
                productCode: "EMP-000001",
                price: 5,
                quantity: 10);
           
            quoteLineItemDTOs2.Add(quoteLineItemDTO2);

            QuoteDTO quoteDTO1 = new QuoteDTO(
                quoteName: "COT-01",
                clientCode: "MTR-300065",
                date: new DateTime(),
                sold: true,
                quoteLineItemDTOs: quoteLineItemDTOs1);

            QuoteDTO quoteDTO2 = new QuoteDTO(
                quoteName: "COT-02",
                clientCode: "MTR-300065",
                date: new DateTime(),
                sold: true,
                quoteLineItemDTOs: quoteLineItemDTOs2);


            quotesDTO.Add(quoteDTO1);
            quotesDTO.Add(quoteDTO2);

            foreach (QuoteDTO q in quotesDTO)
            {
                if (q.QuoteName.Equals(QuoteName))
                {
                    return q;
                }
            }

            return null;

        }

        public void postQuotes(QuoteDTO newQuoteDTO)
        {
            List<QuoteDTO> quotesDTO = new List<QuoteDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs1 = new List<QuoteLineItemDTO>();
            List<QuoteLineItemDTO> quoteLineItemDTOs2 = new List<QuoteLineItemDTO>();

            QuoteLineItemDTO quoteLineItemDTO1 = new QuoteLineItemDTO(
                quoteName: "COT-01",
                productCode: "EMP-000001",
                price: 5,
                quantity: 10);

            quoteLineItemDTOs1.Add(quoteLineItemDTO1);

            QuoteLineItemDTO quoteLineItemDTO2 = new QuoteLineItemDTO(
                quoteName: "COT-02",
                productCode: "EMP-000001",
                price: 5,
                quantity: 10);

            quoteLineItemDTOs2.Add(quoteLineItemDTO2);

            QuoteDTO quoteDTO1 = new QuoteDTO(
                quoteName: "COT-01",
                clientCode: "MTR-300065",
                date: new DateTime(),
                sold: true,
                quoteLineItemDTOs: quoteLineItemDTOs1);

            QuoteDTO quoteDTO2 = new QuoteDTO(
                quoteName: "COT-02",
                clientCode: "MTR-300065",
                date: new DateTime(),
                sold: true,
                quoteLineItemDTOs: quoteLineItemDTOs2);


            quotesDTO.Add(quoteDTO1);
            quotesDTO.Add(quoteDTO2);
            quotesDTO.Add(newQuoteDTO);

        }

        // UpdateQuote()

        // DeleteQuote()
    }
}
