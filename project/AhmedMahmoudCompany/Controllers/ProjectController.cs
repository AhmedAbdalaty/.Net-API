using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Repos.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AhmedMahmoudCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectRepo repo;
        public ProjectController(ProjectRepo repo)
        {
            this.repo = repo;
        } 

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByID([FromRoute] int id)
        {
            return Ok(repo.GetByID(id));
        }
        [HttpPost]
        public IActionResult PostProject(Project proj)
        {
            if (!ModelState.IsValid || proj is null) return BadRequest(ModelState);
            try
            {
                repo.InsertData(proj);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveProject([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var DeletedElement = repo.GetByID(id);
                if (DeletedElement is null) return NotFound();
                repo.RemoveItem(id);
                return Ok(DeletedElement);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPatch("{id}")]
        public IActionResult UpdateProject([FromRoute] int id, [FromBody] Project proj)
        {
            if (!ModelState.IsValid|| proj is null || proj.ProjectNo != id) return BadRequest(ModelState);
            try
            {
                var UpdatedElement = repo.UpdateData(proj);
                return Ok(UpdatedElement);
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
