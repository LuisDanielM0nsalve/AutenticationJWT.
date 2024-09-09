using SpeciesApi.Models;
using System;
using System.Collections.Generic;

namespace SpeciesApi.Services.Interfaces
{
    public interface ITerrestrialServices
    {
        List<Terrestrial> GetTerrestrialsBySpecies(string species);
        List<Terrestrial> GetTerrestrialsByHabitat(string habitat);
        Terrestrial GetTerrestrialByName(string name);
        void DeleteTerrestrialByName(string name);

        Terrestrial GetTerrestrialById(Guid id);
        void DeleteTerrestrial(Guid id);
    }
}
