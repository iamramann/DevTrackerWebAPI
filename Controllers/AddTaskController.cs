using DevTrackerWebAPI.Models;
using DevTrackerWebAPI.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTaskController : ControllerBase
    {
        [HttpPost("add-task")]
        public async Task<IActionResult> AddTask(MyTask task)
        {
            MyTask t = task;
            return Ok();
        }
    }
}
