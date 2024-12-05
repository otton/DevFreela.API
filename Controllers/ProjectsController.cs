﻿using DevFreela.API.Models;
using DevFreela.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Data;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config;
        private readonly IConfigService _configService;
        public ProjectsController(IOptions<FreelanceTotalCostConfig> options,
            IConfigService configService)
        {
            _config = options.Value;
            _configService = configService;
        }
        // GET api/projects?search=crm
        [HttpGet]
        public IActionResult Get(string serch = "")
        {
            return Ok(_configService.GetValue());
        }

        // GET api/projects/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();

            return Ok();
        }

        // POST api/projects
        [HttpPost]
        public IActionResult POST(CreateProjectInputModel model)
        {
            if (model.TotalCost < _config.Minimum) 
            {
                return BadRequest("Número abaixo do limite mínimo!");
            } 
            else if (model.TotalCost > _config.Maximum)
            {
                return BadRequest("Número acima do limite máximo!");
            }
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // PUT api/projects/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        // DELETE api/projects/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        { 
            return NoContent();
        }

        // PUT api/project/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // PUT api/project/1/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        //POST api/project/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {
            return Ok();
        }

    }
}