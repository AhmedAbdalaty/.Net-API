using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Repos.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AhmedMahmoudCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentRepo repo;
        public DepartmentController(DepartmentRepo repo)
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
        public IActionResult PostDepartment(Department dept)
        {
            if (!ModelState.IsValid || dept is null) return BadRequest(ModelState);
            try
            {
                repo.InsertData(dept);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveDept([FromRoute] int id)
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
        public IActionResult UpdateDept([FromRoute] int id, [FromBody] Department dept)
        {
            if (!ModelState.IsValid|| dept is null || dept.DeptNo != id) return BadRequest(ModelState);
            try
            {
                var UpdatedElement = repo.UpdateData(dept);
                return Ok(UpdatedElement);
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
