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
        [HttpGet("{id}")]

        public async Task<ActionResult<Candidato>> GetById(int id)
        {
            var candidato = await _candidatoService.GetById(id);
            if (candidato == null)
            {
                return NotFound();
            }
            return Ok(candidato);
        }

        // POST: api/Candidato_BolsaEmpleo
        [HttpPost]
        public async Task<ActionResult<Candidato>> Create(Candidato candidato)
        {

            Candidato createdCandidato = await _candidatoService.Create(candidato);

            return Ok(createdCandidato);
        }

        // Put: api/Candidato_BolsaEmpleo
        [HttpPut("{id}")] 

        public async Task<IActionResult> Update(Candidato candidato)
        {
            if (candidato == null)
            {
                return BadRequest();
            }
            await _candidatoService.Update(candidato);
            return NoContent();
        }
        // Delete: api/Candidato_BolsaEmpleo

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var candidato = await _candidatoService.GetById(id);
            if (candidato == null)
            {
                return NotFound();
            }
            await _candidatoService.Delete(id);
            return NoContent();
        }

    }
}
