using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //POST api/users
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{id}/profile-picture")]
        public IActionResult PutProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            //Processar a imagem

            return Ok(description);
        }
    }
}
