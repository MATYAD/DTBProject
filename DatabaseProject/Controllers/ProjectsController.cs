using DatabaseProject.Data;
using DatabaseProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {
            _context = context;}
        
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProject()
        {
            var projects = await _context.Projects.ToListAsync();
            return Ok(projects);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProjectByID(int id)
        {
            var projects = await _context.Projects.FindAsync(id);
            if (projects == null)
                return NotFound("No Project With This ID!\n -> Try different ID.");

            return Ok(projects);
        }
    }
}
