using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Repositories
{
    public class AquaticRepository : IAquaticRepository
    {
        private readonly List<Aquatic> _aquatics;

        public AquaticRepository()
        {
            _aquatics = new List<Aquatic>
            {
               new Aquatic()
{
    Id = Guid.NewGuid(),
    Age = 3,
    Name = "Tiburón Blanco",
    Habitat = "Océano",
    IsDomesticated = false,
    Reproduction = Reproduction.Ovoviviparous,
    Species = "Carcharodon carcharias",
    Weight = "1,200 kg",
    Gills = true
},
                new Aquatic()
                {
                    Id = Guid.NewGuid(),
                    Age = 2,
                    Name = "Delfín",
                    Habitat = "Océano",
                    Reproduction = Reproduction.Viviparous,
                    IsDomesticated = false,
                    Species = "Delphinus delphis",
                    Weight = "150 kg",
                    Gills = false
                },
                new Aquatic()
                {
                    Id = Guid.NewGuid(),
                    Age = 1,
                    Name = "Ballena Azul",
                    Habitat = "Océano",
                    Reproduction = Reproduction.Viviparous,
                    IsDomesticated = false,
                    Species = "Balaenoptera musculus",
                    Weight = "120,000 kg",
                    Gills = false
                },
                new Aquatic()
                {
                    Id = Guid.NewGuid(),
                    Age = 4,
                    Name = "Calamar Gigante",
                    Habitat = "Océano profundo",
                    Reproduction = Reproduction.Oviparous,
                    IsDomesticated = false,
                    Species = "Architeuthis dux",
                    Weight = "500 kg",
                    Gills = true
                },
                new Aquatic()
                {
                    Id = Guid.NewGuid(),
                    Age = 1,
                    Name = "Manta Raya",
                    Habitat = "Océano",
                    Reproduction = Reproduction.Ovoviviparous,
                    IsDomesticated = false,
                    Species = "Manta birostris",
                    Weight = "1,350 kg",
                    Gills = true
                }
            };
        }

        public List<Aquatic> GetAquatics()
        {
            return _aquatics;
        }

        public Aquatic GetAquaticById(Guid id)
        {
            // Buscar en la lista _aquatics el objeto con el ID especificado
            return _aquatics.FirstOrDefault(a => a.Id == id);
        }

        public Aquatic GetAquaticByName(string name)
        {
            // Buscar en la lista _aquatics el objeto con el nombre especificado
            return _aquatics.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DeleteAquatic(Aquatic aquatic)
        {
            _aquatics.Remove(aquatic);
        }
    }
}
