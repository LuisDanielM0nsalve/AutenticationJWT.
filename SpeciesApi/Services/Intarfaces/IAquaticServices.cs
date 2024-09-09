using SpeciesApi.Models;
using System;
using System.Collections.Generic;

namespace SpeciesApi.Services.Interfaces
{
    public interface IAquaticServices
    {
        List<Aquatic> GetAquaticsBySpecies(string species);
        List<Aquatic> GetAquaticsByHabitat(string habitat);
        Aquatic GetAquaticByName(string name);
        void DeleteAquaticByName(string name);

        Aquatic GetAquaticById(Guid id);
        void DeleteAquatic(Guid id);
    }
}
