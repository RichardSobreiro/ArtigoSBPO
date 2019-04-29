using API.ArtigoSBPO.ResultFile;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.ArtigoSBPO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        // GET: api/Result
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Domain.ReadJsonInto();

            return new string[] { "value1", "value2" };
        }

        // GET: api/Result/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Result
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Result/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
