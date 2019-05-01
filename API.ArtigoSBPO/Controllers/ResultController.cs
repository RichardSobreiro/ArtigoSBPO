using API.ArtigoSBPO.Dto;
using API.ArtigoSBPO.ResultFile;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.ArtigoSBPO.Controllers
{
    [Route("api/[controller]")]
    public class ResultController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Domain.GetConcreteMixerTimeline());
        }
    }
}
