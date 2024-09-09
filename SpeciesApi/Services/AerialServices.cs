using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Services.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Services
{
    public class AerialService : IAerialServices
    {
        private readonly IAerialRepository _aerialRepository;

        public AerialService(IAerialRepository aerialRepository)
        {
            _aerialRepository = aerialRepository;
        }

        public List<Aerial> GetAerialsBySpecies(string species)
        {
            return _aerialRepository.GetAerials()
                                    .Where(a => a.Species.ToLower() == species.ToLower())
                                    .ToList();
        }

        public List<Aerial> GetAerialsByHabitat(string habitat)
        {
            return _aerialRepository.GetAerials()
                                    .Where(a => a.Habitat.ToLower() == habitat.ToLower())
                                    .ToList();
        }

        public Aerial GetAerialById(Guid id)
        {
            // Primero obtenemos la lista de 'Aerials' y luego buscamos el elemento con el ID especificado
            return _aerialRepository.GetAerials()
                                     .FirstOrDefault(a => a.Id == id);
        }

        public void DeleteAerial(Guid id)
        {
            var aerial = _aerialRepository.GetAerials()
                                          .FirstOrDefault(a => a.Id == id);
            if (aerial != null)
            {
                _aerialRepository.DeleteAerial(aerial);
            }
        }

        public Aerial GetAerialByName(string name) // Implementación del nuevo método
        {
            return _aerialRepository.GetAerials()
                                    .FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }

        public void DeleteAerialByName(string name) // Implementación del nuevo método
        {
            var aerial = GetAerialByName(name);
            if (aerial != null)
            {
                _aerialRepository.DeleteAerial(aerial);
            }
        }
    }
}
