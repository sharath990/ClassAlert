using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webservices.Data;
using Webservices.Models;

namespace CollegeApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageTemplatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MessageTemplatesController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetTemplates()
        {
            return Ok(await _context.MessageTemplates.ToListAsync());
        }

    
        [HttpPost]
        public async Task<IActionResult> AddTemplate([FromBody] MessageTemplate template)
        {
            _context.MessageTemplates.Add(template);
            await _context.SaveChangesAsync();
            return Ok(template);
        }

         
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTemplate(int id, [FromBody] MessageTemplate updatedTemplate)
        {
            var template = await _context.MessageTemplates.FindAsync(id);
            if (template == null) return NotFound("Template not found");

            template.TemplateName = updatedTemplate.TemplateName;
            template.TemplateContent = updatedTemplate.TemplateContent;
            await _context.SaveChangesAsync();
            return Ok(template);
        }

         
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemplate(int id)
        {
            var template = await _context.MessageTemplates.FindAsync(id);
            if (template == null) return NotFound("Template not found");

            _context.MessageTemplates.Remove(template);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}