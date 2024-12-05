using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        // GET api/skills
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
