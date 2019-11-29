using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services;
using Microsoft.Extensions.Configuration;

namespace QuotingAPI.Controllers
{
    
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private IQuoteService _quoteservice;
        private IConfiguration _config;

        public QuotesController(IQuoteService quoteservice, IConfiguration config)
        {
            _quoteservice = quoteservice;
            _config = config;
        }

        // GET api/values
        [HttpGet]
        [Route("quote-management/quotes")]
        public ActionResult<dynamic> GetAll()
        {
            dynamic temp = new
            {
                QuoteLineItemDTO = _quoteservice.GetAllQuotes()
            };
            return temp;
        }

        // GET by name

        [HttpGet]
        [Route("quote-management/quotes/{key}")]
        public ActionResult<QuoteDTO> GetbyName([FromRoute] string key)
        {
            return Ok(_quoteservice.GetQuotebyname(key));
        }


        // POST
        [HttpPost]
        [Route("quote-management/quotes")]
        public IActionResult PostQuote([FromBody] QuoteDTO quote)
        {
            _quoteservice.postQuotes(quote);
            return Ok();
        }

        // PUT

        // DELETE
    }
}
