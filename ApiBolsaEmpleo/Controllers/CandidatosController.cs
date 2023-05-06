using DataAccess.Entities;
using Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBolsaEmpleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatosService _candidatoService;

        public CandidatosController(ICandidatosService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidato>>> GetAll()
        {

            List<Candidato> listCandidatos = await _candidatoService.GetAll();

            return Ok(listCandidatos);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Candidato>> Create(Candidato candidato)
        {

            Candidato createdCandidato = await _candidatoService.Create(candidato);

            return Ok(createdCandidato);
        }
    }
}
