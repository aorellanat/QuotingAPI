using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IQuoteService
    {
        List<QuoteDTO> GetAllQuotes();
        QuoteDTO GetQuotebyname(string QuoteName);
        void postQuotes(QuoteDTO newQuoteDTO);
    }
}
