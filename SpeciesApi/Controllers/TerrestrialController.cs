using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpeciesApi.Services.Intarfaces;
using SpeciesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TerrestrialController : ControllerBase
    {
        private readonly ITerrestrialServices _terrestrialService;

        public TerrestrialController(ITerrestrialServices terrestrialService)
        {
            _terrestrialService = terrestrialService;
        }


        // GET api/<TerrestrialController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var terrestrial = _terrestrialService.GetTerrestrialByName(name);
            if (terrestrial != null)
            {
                return Ok(terrestrial);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<TerrestrialController>/species/{species}
        [HttpGet("species/{species}")]
        public IActionResult GetBySpecies(string species)
        {
            var terrestrials = _terrestrialService.GetTerrestrialsBySpecies(species);
            if (terrestrials != null && terrestrials.Any())
            {
                return Ok(terrestrials);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<TerrestrialController>/habitat/{habitat}
        [HttpGet("habitat/{habitat}")]
        public IActionResult GetByHabitat(string habitat)
        {
            var terrestrials = _terrestrialService.GetTerrestrialsByHabitat(habitat);
            if (terrestrials != null && terrestrials.Any())
            {
                return Ok(terrestrials);
            }
            else
            {
                return NotFound();
            }
        }


        // DELETE api/<TerrestrialController>/name/{name}
        [HttpDelete("name/{name}")]
        public IActionResult DeleteByName(string name)
        {
            var terrestrial = _terrestrialService.GetTerrestrialByName(name);
            if (terrestrial == null)
            {
                return NotFound();
            }

            _terrestrialService.DeleteTerrestrialByName(name);
            return NoContent();
        }
    }
}
