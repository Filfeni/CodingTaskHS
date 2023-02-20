using Azure.Core;
using BlogHS.API.Services.Entry;
using BlogHS.Domain.Models.Entry;
using FluentValidation;
using FluentValidation.Results;
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
        private readonly IValidator<EntryDTO> _entryValidator;
        private readonly IValidator<BaseEntryDTO> _baseEntryValidator;

        public EntryController(EntryService service, ILogger<EntryController> logger, IValidator<EntryDTO> entryValidator, IValidator<BaseEntryDTO> baseEntryValidator)
        {
            _service = service;
            _logger = logger;
            _entryValidator = entryValidator;
            _baseEntryValidator = baseEntryValidator;
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
            var validation = await _baseEntryValidator.ValidateAsync(dto);

            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors?.Select(e => new ValidationResult()
                {
                    Errors = validation.Errors
                }));
            }
            var entry = await _service.CreateEntryAsync(dto);
            return Ok(entry);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] EntryDTO dto)
        {
            var validation = await _entryValidator.ValidateAsync(dto);

            if (!validation.IsValid)
            {
                return BadRequest(validation.Errors);
            }

            var successful = await _service.UpdateEntryAsync(dto);
            if (!successful)
            {
                return BadRequest(validation.Errors);
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
