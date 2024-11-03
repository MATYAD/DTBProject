using DatabaseProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly DataContext _context;

        public TasksController(DataContext context)
        {
            _context = context;}
        
        [HttpGet]
        public async Task<ActionResult<List<Task>>> GetAllTasks()
        {
            var tasks = await _context.Tasks.ToListAsync();
            return Ok(tasks);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Task>> GetTaskByID(int id)
        {
            var tasks = await _context.Tasks.FindAsync(id);
            if (tasks == null)
                return NotFound("No Task With This ID!\n -> Try different ID.");

            return Ok(tasks);
        }
    }
}
