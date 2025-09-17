using Application.DTO;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpmController : Controller
    {
        private readonly IOpmService _service;
        public OpmController(IOpmService service)
        {
            _service = service;
        }
        [HttpGet("{CodOpm}")]
        public async Task<ActionResult<OpmDto>> Get(string CodOpm)
        {
            var opm = await _service.GetOpm(CodOpm);
            return Ok(opm);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpmDto>>> GetAll()
        {
            var opms = await _service.GetAll();
            return Ok(opms);
        }

        [HttpPost]
        public async Task<ActionResult<OpmDto>> Create(OpmDto dto)
        {
            var novaopm = await _service.Create(dto);
            return Created($"api/opm/{novaopm.CodOpm}", novaopm);
        }
        
    }
}
