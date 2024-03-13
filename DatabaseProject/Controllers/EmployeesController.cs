using DatabaseProject.Data;
using DatabaseProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        
        private readonly DataContext _context;

        public EmployeesController(DataContext context)
        {
            _context = context;}
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return Ok(employees);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetAuthorByID(int id)
        {
            var author = await _context.Employees.FindAsync(id);
            if (author == null)
                return NotFound("No Employee With This ID!\n -> Try different ID.");

            return Ok(author);
        }
    }
}


