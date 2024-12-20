using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webservices.Data;
using Webservices.Models;

namespace CollegeApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcademicController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AcademicController(AppDbContext context)
        {
            _context = context;
        }

        // Batches
        [HttpGet("batches")]
        public async Task<IActionResult> GetBatches()
        {
            return Ok(await _context.Batches.ToListAsync());
        }

        [HttpPost("batches")]
        public async Task<IActionResult> AddBatch([FromBody] Batch batch)
        {
            _context.Batches.Add(batch);
            await _context.SaveChangesAsync();
            return Ok(batch);
        }

        // Classes
        [HttpGet("classes")]
        public async Task<IActionResult> GetClasses()
        {
            return Ok(await _context.Classes.ToListAsync());
        }

        [HttpPost("classes")]
        public async Task<IActionResult> AddClass([FromBody] Class newClass)
        {
            _context.Classes.Add(newClass);
            await _context.SaveChangesAsync();
            return Ok(newClass);
        }

        // Streams
        [HttpGet("streams")]
        public async Task<IActionResult> GetStreams()
        {
            return Ok(await _context.Streams.ToListAsync());
        }

        [HttpPost("streams")]
        public async Task<IActionResult> AddStream([FromBody] Stream stream)
        {
            _context.Streams.Add(stream);
            await _context.SaveChangesAsync();
            return Ok(stream);
        }

        // Sections
        [HttpGet("sections")]
        public async Task<IActionResult> GetSections()
        {
            return Ok(await _context.Sections.ToListAsync());
        }

        [HttpPost("sections")]
        public async Task<IActionResult> AddSection([FromBody] Section section)
        {
            _context.Sections.Add(section);
            await _context.SaveChangesAsync();
            return Ok(section);
        }
    }
}
