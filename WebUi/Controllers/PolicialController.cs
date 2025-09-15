using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;

namespace WebUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicialController : Controller
    {
        private readonly IPolicialService _service;
        public PolicialController()
        {
            
        }


    }
}
