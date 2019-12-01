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
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            return quotes;
        }

        public Quote GetQuoteByName(string quoteName)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            foreach (Quote quote in quotes)
            {
                if (quote.QuoteName.Equals(quoteName))
                {
                    return quote;
                }
            }

            return new Quote();
        }

        public List<Quote> GetAllPending()
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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

        public Quote UpdateByName(string quoteName, Quote quoteUpdated)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            try
            {
                int index = quotes.IndexOf(quotes.Find(quote => quote.QuoteName.Equals(quoteName)));
                quotes[index] = quoteUpdated;
                return quotes[index];
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
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-001", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "PTR-65000001", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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
