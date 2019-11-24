using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrackingApp.API.Data;
using TrackingApp.API.Dtos;
using TrackingApp.API.models;

namespace TrackingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _repo;
        public DepartmentController(IDepartmentRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var newList = new List<DepartmentForListDto>();
            int counter = 1;
            var departments = await _repo.GetDepartments();

            foreach (var rec in departments)
            {
                var newRec = new DepartmentForListDto()
                {
                    Id = rec.Id,
                    Count = counter++,
                    Name = rec.Name
                };
                newList.Add(newRec);
            }
            return Ok(newList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var department = await _repo.GetDepartment(id);
            return Ok(department);
        }

        [HttpPost]
        public async Task<ActionResult> AddDepartment(Department department)
        {
            _repo.Add(department);
            await _repo.SaveAll();
            return StatusCode(201);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            var department = await _repo.GetDepartment(id);
            _repo.Delete(department);
            await _repo.SaveAll();

            return Ok();
        }


    }
}