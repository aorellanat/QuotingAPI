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
        public ActionResult<IEnumerable<Quote>> GetAll()
        {
            return _quoteservice.GetAll();
        }

        // GET by name
        [HttpGet]
        [Route("quote-management/quotes/{quoteName}")]
        public ActionResult<Quote> GetByName([FromRoute] string quoteName)
        {
            return Ok(_quoteservice.GetQuoteByName(quoteName));
        }

        // GET REPORTS
        /* [HttpGet]
        [Route("quote-management/quotes/pending")] sold = false

        [HttpGet]
        [Route("quote-management/quotes/sold")] sold = true*/

        // POST
        [HttpPost]
        [Route("quote-management/quotes")]
        public ActionResult<Quote> Create([FromBody] Quote newQuote)
        {
            return Ok(_quoteservice.Save(newQuote));
        }

        // PUT
        [HttpPut]
        [Route("quote-management/quotes/{quoteName}")]
        public IActionResult Update([FromRoute] string quoteName, [FromBody] Quote quoteToUpdate)
        {
            _quoteservice.UpdateByName(quoteName, quoteToUpdate);
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
