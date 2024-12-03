using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZiekenFonds.API.Data.UnitOfWork;
using ZiekenFonds.API.Dto.Activiteit;
using ZiekenFonds.API.Dto.Groepsreis;
using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroepsreisController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public GroepsreisController(IUnitOfWork context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<GroepsreisOphalenDto>> GetGroepsreizen()
        {
            IEnumerable<Groepsreis> groepreizen = await _context.GroepsReisRepository.GetCompleteGroepsReizenAsync();

            List<GroepsreisOphalenDto> dtos = _mapper.Map<List<GroepsreisOphalenDto>>(groepreizen);

            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GroepsreisOphalenDto>> GetGroepsreis(int id)
        {
            Groepsreis groepsreis = await _context.GroepsReisRepository.GetCompleteGroepsReis(id);

            if (groepsreis == null)
            {
                return NotFound("Er is geen groepsreis gevonden met deze id");
            }

            GroepsreisOphalenDto dto = _mapper.Map<GroepsreisOphalenDto>(groepsreis);

            return Ok(dto);
        }
    }
}