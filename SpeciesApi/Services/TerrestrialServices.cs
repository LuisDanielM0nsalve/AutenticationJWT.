using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Services
{
    public class TerrestrialServices : ITerrestrialServices
    {
        private readonly ITerrestrialRepository _terrestrialRepository;

        public TerrestrialServices(ITerrestrialRepository terrestrialRepository)
        {
            _terrestrialRepository = terrestrialRepository;
        }

        public List<Terrestrial> GetTerrestrialsBySpecies(string species)
        {
            return _terrestrialRepository.GetTerrestrials()
                                         .Where(t => t.Species.ToLower() == species.ToLower())
                                         .ToList();
        }

        public List<Terrestrial> GetTerrestrialsByHabitat(string habitat)
        {
            return _terrestrialRepository.GetTerrestrials()
                                         .Where(t => t.Habitat.ToLower() == habitat.ToLower())
                                         .ToList();
        }

        public Terrestrial GetTerrestrialById(Guid id)
        {
            return _terrestrialRepository.GetTerrestrials()
                                          .FirstOrDefault(t => t.Id == id);
        }

        public void DeleteTerrestrial(Guid id)
        {
            var terrestrial = _terrestrialRepository.GetTerrestrials()
                                                    .FirstOrDefault(t => t.Id == id);
            if (terrestrial != null)
            {
                _terrestrialRepository.DeleteTerrestrial(terrestrial);
            }
        }

        public Terrestrial GetTerrestrialByName(string name)
        {
            return _terrestrialRepository.GetTerrestrials()
                                          .FirstOrDefault(t => t.Name.ToLower() == name.ToLower());
        }

        public void DeleteTerrestrialByName(string name)
        {
            var terrestrial = GetTerrestrialByName(name);
            if (terrestrial != null)
            {
                _terrestrialRepository.DeleteTerrestrial(terrestrial);
            }
        }
    }
}
