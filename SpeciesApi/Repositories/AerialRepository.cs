using SpeciesApi.Models;
using SpeciesApi.Repositories.Interfaces;
using SpeciesApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeciesApi.Repositories
{
    public class AerialRepository : IAerialRepository
    {
        private readonly List<Aerial> _aerials;

        public AerialRepository()
        {
            _aerials = new List<Aerial>
            {
                new Aerial()
                {
                    Id = Guid.NewGuid(),
                    Age = 1,
                    Name = "Paloma",
                    Habitat = "Plaza",
                    IsDomesticated = true,
                    Reproduction = Reproduction.Oviparous,
                    Species = "paloma bravía",
                    Weight = "1.5 lb",
                    WingSpan = "60cm"
                },
                new Aerial()
                {
                    Id = Guid.NewGuid(),
                    Age = 2,
                    Name = "Águila",
                    Habitat = "Montañas",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Oviparous,
                    Species = "águila real",
                    Weight = "6.0 lb",
                    WingSpan = "200cm"
                },
                new Aerial()
                {
                    Id = Guid.NewGuid(),
                    Age = 3,
                    Name = "Gaviota",
                    Habitat = "Costas",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Oviparous,
                    Species = "gaviota argéntea",
                    Weight = "2.0 lb",
                    WingSpan = "150cm"
                },
                new Aerial()
                {
                    Id = Guid.NewGuid(),
                    Age = 4,
                    Name = "Cóndor",
                    Habitat = "Cordilleras",
                    IsDomesticated = false,
                    Reproduction = Reproduction.Oviparous,
                    Species = "cóndor andino",
                    Weight = "15.0 lb",
                    WingSpan = "300cm"
                },
                new Aerial()
                {
                    Id = Guid.NewGuid(),
                    Age = 5,
                    Name = "Colibrí",
                    Habitat = "Bosques tropicales",
                    Reproduction = Reproduction.Oviparous,
                    IsDomesticated = false,
                    Species = "colibrí esmeralda",
                    Weight = "0.1 lb",
                    WingSpan = "10cm"
                }

            };
        }

        public List<Aerial> GetAerials()
        {
            return _aerials;
        }

        public Aerial GetAerialById(Guid id)
        {
            // Buscar en la lista _aerials el objeto con el ID especificado
            return _aerials.FirstOrDefault(a => a.Id == id);
        }

        public void DeleteAerial(Aerial aerial)
        {
            _aerials.Remove(aerial);
        }
    }
}
