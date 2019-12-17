using Services.Models;
using Services.Exceptions;
using System;
using System.Collections.Generic;

namespace Services
{
    public class QuoteService : IQuoteService
    {
        public List<Quote> GetAll()
        {
            Console.WriteLine("\nSending all quotes...\n");

            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MT-47623444", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            return quotes;
        }

        public Quote GetQuoteByName(string quoteName)
        {

			if (String.IsNullOrEmpty(quoteName))
			{
				throw new QuoteNameInvalid();
			}
			Console.WriteLine("\nSending quote with name " + quoteName + "...\n");

            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MT-47623444", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };
			Quote actualQuote = null;
            foreach (Quote quote in quotes)
            {
                if (quote.QuoteName.Equals(quoteName))
                {
					actualQuote =  quote;
                }
            }
			if( actualQuote == null)
			{
				throw new QuoteNotFound();
			}
			else
			{

				return actualQuote;
   }

        }

        public List<Quote> GetAllPending()
        {
            Console.WriteLine("\nSend all pending quotes...\n");

            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MT-47623444", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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
            Console.WriteLine("\nSending all sold quotes...\n");

            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
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
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };


            Quote quotefinded = quotes.Find(x => x.QuoteName.Contains(quote.QuoteName));
            if (quotefinded != null)
            {
                throw new QuoteNameAlreadyExists();
            }

            try
            {
                quotes.Add(quote);

                Console.WriteLine("\nSaving quote with name: " + quote.QuoteName + ", client code: " + quote.ClientCode + ", date: " + quote.Date + ", sold: " + quote.Sold + ", items: " + quote.QuoteLineItems + "\n");

                return quote;
            }

            catch (QuoteNameAlreadyExists qd)
            {
                throw qd;
            }
        }

        public Quote UpdateByName(string quoteName, Quote quoteUpdated)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            if (String.IsNullOrEmpty(quoteName) | String.IsNullOrEmpty(quoteUpdated.QuoteName))
            {
                throw new QuoteNameInvalid();
            }

            Quote quotefinded = quotes.Find(x => x.QuoteName.Contains(quoteUpdated.QuoteName));
            if (quotefinded != null)
            {
                throw new QuoteNameAlreadyExists();
            }
			else if ( quotefinded == null)
			{
				throw new QuoteNameInvalid();
			}

            try
            {
                int index = quotes.IndexOf(quotes.Find(quote => quote.QuoteName.Equals(quoteName)));
                quotes[index] = quoteUpdated;

                Console.WriteLine("\nUpdating quote with name: " + quoteName + ", client code: " + quoteUpdated.ClientCode + ", date: " + quoteUpdated.Date + ", sold: " + quoteUpdated.Sold + ", items: " + quoteUpdated.QuoteLineItems + "\n");

                return quotes[index];
            }
            catch (QuoteNameInvalid qe)
            {
                throw qe;
            }
            catch (QuoteNameAlreadyExists qd)
            {
                throw qd;
            }



        }

        public void DeleteByName(string quoteName)
        {
            List<QuoteLineItem> quoteLineItem = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-001", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };
            List<QuoteLineItem> quoteLineItem2 = new List<QuoteLineItem>()
            {
                new QuoteLineItem() { QuoteName = "COT-002", ProductCode = "EMP-1", Price = 5, Quantity = 10 }
            };

            List<Quote> quotes = new List<Quote>() {
                new Quote() { QuoteName = "COT-001", ClientCode = "MTR-64000001", Date = new DateTime(2019, 5, 12), Sold = false, QuoteLineItems = quoteLineItem },
                new Quote() { QuoteName = "COT-002", ClientCode = "VC-63695635", Date = new DateTime(2019, 5, 15), Sold = true, QuoteLineItems = quoteLineItem2 }
            };

            Quote quotefinded = quotes.Find(x => x.QuoteName.Contains(quoteName));
            if (String.IsNullOrEmpty(quoteName) | quotefinded == null)
            {
                throw new QuoteNameDoesNotExist();
            }

            try
            {
                quotes.RemoveAll(quote => quote.QuoteName.Equals(quoteName));

                Console.WriteLine("\nRemoving quote with name " + quoteName + "...\n");

            }
            catch (QuoteNameDoesNotExist qne)
            {
                throw qne;
            }
        }

        // Error
        public List<Quote> GetAllWithError()
        {
            try
            {
                throw new NullReferenceException("Exception: list value null");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
