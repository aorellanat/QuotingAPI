using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class QuoteService:IQuoteService
    {
        public List<Quote> GetAll()
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem }
            };

            return quotes;
        }

        public Quote GetQuoteByName(string quoteName)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem }
            };

            foreach (Quote quote in quotes)
            {
                if (quote.QuoteName.Equals(quoteName))
                {
                    return quote;
                }
            }

            return null;
        }

        public List<Quote> GetAllPending()
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = false, QuoteLineItems = quoteLineItem }
            };

            List<Quote> quotesPending = new List<Quote>();


            foreach (Quote quote in quotes)
            {
                if (!quote.Sold)
                {
                    quotesPending.Add(quote);
                }
            }

            return quotesPending;
        }

        public List<Quote> GetAllSold()
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = false, QuoteLineItems = quoteLineItem }
            };

            List<Quote> quotesSold = new List<Quote>();


            foreach (Quote quote in quotes)
            {
                if (quote.Sold)
                {
                    quotesSold.Add(quote);
                }
            }

            return quotesSold;
        }

        public Quote Save(Quote quote)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem }
            };

            try
            {
                quotes.Add(quote);

                return quote;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void UpdateByName(string quoteName, Quote quoteUpdated)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem }
            };

            try
            {
                int index = quotes.IndexOf(quotes.Find(quote => quote.QuoteName.Equals(quoteName)));
                quotes[index] = quoteUpdated;
            }
            catch (System.Exception)
            {
                throw;
            } 
        }

        public void DeleteByName(string quoteName)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-01", ProductCode = "EMP-000001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-01", ClientCode = "MTR-300065", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-02", ClientCode = "PTR-300015", Date = new DateTime(), Sold = true, QuoteLineItems = quoteLineItem }
            };

            try
            {
                quotes.RemoveAll(quote => quote.QuoteName.Equals(quoteName));
            }
            catch (System.Exception)
            {
                throw;
            }
            
        }
    }
}
