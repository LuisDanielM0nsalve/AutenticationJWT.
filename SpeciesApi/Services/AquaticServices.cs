using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Services
{
    public class AquaticServices : IAquaticServices
    {
        private readonly IAquaticRepository _aquaticRepository;

        public AquaticServices(IAquaticRepository aquaticRepository)
        {
            _aquaticRepository = aquaticRepository;
        }

        public List<Aquatic> GetAquaticsBySpecies(string species)
        {
            return _aquaticRepository.GetAquatics()
                                     .Where(a => a.Species.ToLower() == species.ToLower())
                                     .ToList();
        }

        public List<Aquatic> GetAquaticsByHabitat(string habitat)
        {
            return _aquaticRepository.GetAquatics()
                                     .Where(a => a.Habitat.ToLower() == habitat.ToLower())
                                     .ToList();
        }

        public Aquatic GetAquaticById(Guid id)
        {
            return _aquaticRepository.GetAquatics()
                                     .FirstOrDefault(a => a.Id == id);
        }

        public void DeleteAquatic(Guid id)
        {
            var aquatic = _aquaticRepository.GetAquatics()
                                            .FirstOrDefault(a => a.Id == id);
            if (aquatic != null)
            {
                _aquaticRepository.DeleteAquatic(aquatic);
            }
        }

        public Aquatic GetAquaticByName(string name)
        {
            return _aquaticRepository.GetAquatics()
                                     .FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }

        public void DeleteAquaticByName(string name)
        {
            var aquatic = GetAquaticByName(name);
            if (aquatic != null)
            {
                _aquaticRepository.DeleteAquatic(aquatic);
            }
        }
    }
}
