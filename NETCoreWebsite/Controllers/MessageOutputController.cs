using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using NETCoreWebsite.Models;
using NETCoreWebsite.Services;

namespace NETCoreWebsite.Controllers
{
    [Produces("application/json")]
    [Route("api/MessageOutput")]
    public class MessageOutputController : Controller
    {
        // GET: api/MessageOutput
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MessageOutput/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"value: {id}";
        }

        /// <summary>
        /// This is custom. Does not properly display as HTML in browser.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("htmlPage")]
        public string GetHTML()
        {
            return @"<article>
<header>
<h1>Most important heading here</h1>
<h3>Less important heading here</h3>
<p>Some additional information here</p>
</header>
<p>Lorem Ipsum dolor set amet....</p>
</article>";
        }

        // POST: api/MessageOutput
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        [Route("Explicit")]
        public void ExplicitPost([FromBody]RepeatMessageModel value)
        {
            IConsoleOutputService consoleOutputService = new Services.Implementations.ConsoleOutputService();
            consoleOutputService.HelloFormat(value);
        }

        // PUT: api/MessageOutput/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
