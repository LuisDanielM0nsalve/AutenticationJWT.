using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpeciesApi.Services.Intarfaces;
  // Corregí el nombre del espacio de nombres "Interfaces"

namespace SpeciesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AerialController : ControllerBase
    {
        private readonly IAerialServices _aerialService;  // Corregí el nombre a "IAerialService"

        public AerialController(IAerialServices aerialService)  // Corregí el nombre a "IAerialService"
        {
            _aerialService = aerialService;
        }


        // GET api/<AerialController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var aerial = _aerialService.GetAerialByName(name);
            if (aerial != null)
            {
                return Ok(aerial);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<AerialController>/species/{species}
        [HttpGet("species/{species}")]
        public IActionResult GetBySpecies(string species)
        {
            var aerials = _aerialService.GetAerialsBySpecies(species);
            if (aerials != null && aerials.Any())
            {
                return Ok(aerials);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<AerialController>/habitat/{habitat}
        [HttpGet("habitat/{habitat}")]
        public IActionResult GetByHabitat(string habitat)
        {
            var aerials = _aerialService.GetAerialsByHabitat(habitat);
            if (aerials != null && aerials.Any())
            {
                return Ok(aerials);
            }
            else
            {
                return NotFound();
            }
        }


        // DELETE api/<AerialController>/name/{name}
        [HttpDelete("name/{name}")]
        public IActionResult DeleteByName(string name)
        {
            var aerial = _aerialService.GetAerialByName(name);
            if (aerial == null)
            {
                return NotFound();
            }

            _aerialService.DeleteAerialByName(name);
            return NoContent();
        }

    }
}
