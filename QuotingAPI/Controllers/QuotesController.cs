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

        // GET quotes
        [HttpGet]
        [Route("quote-management/quotes")]
        public ActionResult<dynamic> GetAll()
        {
            dynamic temp = new
            {
                quoteList = _quoteservice.GetAll()
            };
            return temp;
        }

        // GET by name

        [HttpGet]
        [Route("quote-management/quotes/{quoteName}")]
        public ActionResult<QuoteDTO> GetByName([FromRoute] string quoteName)
        {
            return Ok(_quoteservice.GetQuoteByname(quoteName));
        }


        // POST
        [HttpPost]
        [Route("quote-management/quotes")]
        public IActionResult Post([FromBody] QuoteDTO quote)
        {
            _quoteservice.PostQuote(quote);
            return Ok();
        }

        // PUT
        [HttpPut]
        [Route("quote-management/quotes/{quoteName}")]
        public IActionResult Update([FromRoute] string quoteName, [FromBody] QuoteDTO quoteUpdated)
        {
            _quoteservice.UpdateByName(quoteName, quoteUpdated);
            return Ok();
        }

        // DELETE
        [HttpDelete]
        [Route("quote-management/quotes/{quoteName}")]
        public IActionResult DeleteByName([FromRoute] string quoteName)
        {
            _quoteservice.DeleteByName(quoteName);
            return Ok();
        }
    }
}
