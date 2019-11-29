using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IQuoteService
    {
        List<QuoteDTO> GetAll();
        QuoteDTO GetQuoteByname(string quoteName);
        void PostQuote(QuoteDTO newQuoteDTO);
        void UpdateByName(string quoteName, QuoteDTO quoteUpdated);
        void DeleteByName(string quoteName);

    }
}
