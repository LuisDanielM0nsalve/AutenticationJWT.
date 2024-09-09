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
    public class AquaticController : ControllerBase
    {
        private readonly IAquaticServices _aquaticService;

        public AquaticController(IAquaticServices aquaticService)
        {
            _aquaticService = aquaticService;
        }


        // GET api/<AquaticController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var aquatic = _aquaticService.GetAquaticByName(name);
            if (aquatic != null)
            {
                return Ok(aquatic);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<AquaticController>/species/{species}
        [HttpGet("species/{species}")]
        public IActionResult GetBySpecies(string species)
        {
            var aquatics = _aquaticService.GetAquaticsBySpecies(species);
            if (aquatics != null && aquatics.Any())
            {
                return Ok(aquatics);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<AquaticController>/habitat/{habitat}
        [HttpGet("habitat/{habitat}")]
        public IActionResult GetByHabitat(string habitat)
        {
            var aquatics = _aquaticService.GetAquaticsByHabitat(habitat);
            if (aquatics != null && aquatics.Any())
            {
                return Ok(aquatics);
            }
            else
            {
                return NotFound();
            }
        }


        // DELETE api/<AquaticController>/name/{name}
        [HttpDelete("name/{name}")]
        public IActionResult DeleteByName(string name)
        {
            var aquatic = _aquaticService.GetAquaticByName(name);
            if (aquatic == null)
            {
                return NotFound();
            }

            _aquaticService.DeleteAquaticByName(name);
            return NoContent();
        }
    }
}
