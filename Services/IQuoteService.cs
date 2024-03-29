﻿using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IQuoteService
    {
        List<Quote> GetAll();

        Quote GetQuoteByName(string quoteName);

        List<Quote> GetAllSold();

        List<Quote> GetAllPending();

        Quote Save(Quote quote);

        Quote UpdateByName(string quoteName, Quote quoteUpdated);

        void DeleteByName(string quoteName);
        List<Quote> GetAllWithError();
    }
}
