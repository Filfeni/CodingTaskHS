using Azure.Core;
using BlogHS.API.Services.Entry;
using BlogHS.Domain.Models.Entry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogHS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private readonly EntryService _service;
        private readonly ILogger<EntryController> _logger;

        public EntryController(ILogger<EntryController> logger
            , EntryService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entries = await _service.GetAllAsync();
            return Ok(entries);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await _service.GetByIdAsync(id);
            return Ok(entry);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BaseEntryDTO dto)
        {
            var entry = await _service.CreateEntryAsync(dto);
            return Ok(entry);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] EntryDTO dto)
        {
            var successful = await _service.UpdateEntryAsync(dto);
            if (!successful)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var successful = await _service.DeleteEntryAsync(id);
            if (!successful)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
