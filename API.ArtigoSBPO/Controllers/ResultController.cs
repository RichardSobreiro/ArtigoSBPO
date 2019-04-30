using API.ArtigoSBPO.Dto;
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
        public IEnumerable<BetoneiraDto> Get()
        {
            return Domain.GetConcreteMixerTimeline(); ;
        }
    }
}
