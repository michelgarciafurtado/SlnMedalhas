using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTO;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicialController : Controller
    {
        private readonly IPolicialService _service;
        public PolicialController(IPolicialService service)
        {
            _service = service;
        }
        [HttpGet("{re}")]
        public async Task<ActionResult<PolicialDto>> Get(string re)
        {
           var policial = await _service.GetPolicial(re);
            return Ok(policial);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PolicialDto>>> GetAll()
        {
            var policiais = await _service.GetAll();
            return Ok(policiais);
        }

        [HttpPost]
        public async Task<ActionResult<PolicialDto>> Create([FromBody] PolicialDto dto)
        {
           var novopolicial = await _service.Create(dto);
            return Created($"api/policial/{novopolicial.Re}",novopolicial);
        }

    }
}
