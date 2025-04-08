using Microsoft.AspNetCore.Mvc;
using ReceiptReimbursementAPI.DTOs;
using ReceiptReimbursementAPI.Models;
using ReceiptReimbursementAPI.Data;

namespace ReceiptReimbursementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReimbursementsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ReimbursementsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] ReimbursementUploadDto dto)
        {
            if (dto.File == null || dto.File.Length == 0)
                return BadRequest("No file uploaded.");

            var uploadsFolder = Path.Combine(_env.WebRootPath ?? "wwwroot", "Uploads");
            Directory.CreateDirectory(uploadsFolder);

            var uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(dto.File.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await dto.File.CopyToAsync(stream);
            }

            var reimbursement = new Reimbursement
            {
                Date = dto.Date,
                Amount = dto.Amount,
                Description = dto.Description,
                FilePath = filePath
            };

            _context.Reimbursements.Add(reimbursement);
            await _context.SaveChangesAsync();

            return Ok(reimbursement);
        }
    }
}
