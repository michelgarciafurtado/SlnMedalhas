using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class MedalhasController : Controller
    {
        private readonly IMedalhaService _service;

        public MedalhasController(IMedalhaService service)
        {
            _service = service;            
        }
        [HttpPost]
        public async Task<ActionResult<MedalhaDto>> Create([FromBody] MedalhaDto dto)
        {
            var entity = await _service.Create(dto);
            return Created($"api/medalhas/{entity.IdMedalha}", entity);
        }

        [HttpGet]
        public async Task<IEnumerable<MedalhaDto>> GetAll()
        {
            var list = await _service.GetAll();
            return list;
        }
        [HttpGet("{re}")]
        public async Task<IEnumerable<MedalhaDto>> GetMedalhasPolicial(string re)
        {
            var list = await _service.GetMedalhasPolicial(re);
            return list;
        }
    }
}
