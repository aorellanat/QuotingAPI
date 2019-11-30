using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IQuoteService
    {
        List<Quote> GetAll();

        Quote GetQuoteByName(string quoteName);

        Quote Save(Quote quote);

        void UpdateByName(string quoteName, Quote quoteUpdated);

        void DeleteByName(string quoteName);
    }
}
