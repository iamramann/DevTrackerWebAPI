using DevTrackerWebAPI.Data;
using DevTrackerWebAPI.Models;
using DevTrackerWebAPI.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevTrackerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IValuesRepo valuesRepo;

        public ValuesController(DataContext context, IValuesRepo valuesRepo)
        {
            this.context = context;
            this.valuesRepo = valuesRepo;
        }

        [HttpGet("associates")]
        public async Task<IActionResult> GetAssociates()
        {
            return Ok(await valuesRepo.GetAssociatesAsync());
        }

        [HttpGet("task-types")]
        public async Task<IActionResult> GetTaskTypes()
        {
            return Ok(await valuesRepo.GetTaskTypesAsync());
        }

        [HttpPost("associates-test")]
        public async Task<IActionResult> GetAssociatesPost(TaskType t)
        {
            return Ok();
        }
    }
}
