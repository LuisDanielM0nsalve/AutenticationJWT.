using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Repositories
{
    public class TerrestrialRepository : ITerrestrialRepository
    {
        private readonly List<Terrestrial> _terrestrials;

        public TerrestrialRepository()
        {
            _terrestrials = new List<Terrestrial>
            {
                new Terrestrial()
                {
                    Id = Guid.NewGuid(),
                    Age = 4,
                    Name = "Elefante",
                    Habitat = "Sabana",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Viviparous,
                    Species = "Loxodonta africana",
                    Weight = "6,000 kg",
                    NumberOfLegs = 4
                },
                new Terrestrial()
                {
                    Id = Guid.NewGuid(),
                    Age = 7,
                    Name = "León",
                    Habitat = "Sabana",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Viviparous,
                    Species = "Panthera leo",
                    Weight = "190 kg",
                    NumberOfLegs = 4
                },
                new Terrestrial()
                {
                    Id = Guid.NewGuid(),
                    Age = 5,
                    Name = "Rhinoceros",
                    Habitat = "Sabana",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Viviparous,
                    Species = "Rhinoceros unicornis",
                    Weight = "2,200 kg",
                    NumberOfLegs = 4
                },
                new Terrestrial()
                {
                    Id = Guid.NewGuid(),
                    Age = 6,
                    Name = "Giraffe",
                    Habitat = "Sabana",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Viviparous,
                    Species = "Giraffa camelopardalis",
                    Weight = "800 kg",
                    NumberOfLegs = 4
                },
                new Terrestrial()
                {
                    Id = Guid.NewGuid(),
                    Age = 3,
                    Name = "Cebra",
                    Habitat = "Sabana",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Viviparous,
                    Species = "Equus zebra",
                    Weight = "350 kg",
                    NumberOfLegs = 4
                }
            };
        }

        public List<Terrestrial> GetTerrestrials()
        {
            return _terrestrials;
        }

        public Terrestrial GetTerrestrialById(Guid id)
        {
            // Buscar en la lista _terrestrials el objeto con el ID especificado
            return _terrestrials.FirstOrDefault(t => t.Id == id);
        }

        public Terrestrial GetTerrestrialByName(string name)
        {
            // Buscar en la lista _terrestrials el objeto con el nombre especificado
            return _terrestrials.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DeleteTerrestrial(Terrestrial terrestrial)
        {
            _terrestrials.Remove(terrestrial);
        }
    }
}



