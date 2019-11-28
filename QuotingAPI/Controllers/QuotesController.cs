using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services;

namespace QuotingAPI.Controllers
{
    
    [ApiController]
    public class QuotesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("quote-management/quotes")]
        public ActionResult<IEnumerable<QuoteDTO>> GetAll()
        {
           QuoteService quoteService = new QuoteService();
            return Ok(quoteService.GetAllQuotes());
        }

    }
}
