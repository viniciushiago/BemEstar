using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BemEstar.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BemEstar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlimentoController : ControllerBase
    {
        private readonly IAlimentoService _service;

        public AlimentoController(IAlimentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAlimentos()
        {
            var alimentos = _service.GetAlimentos();
            return Ok(alimentos);
        }
    }
}
