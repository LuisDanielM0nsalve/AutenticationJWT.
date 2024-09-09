using SpeciesApi.Models;
using System;
using System.Collections.Generic;

namespace SpeciesApi.Repositories.Interfaces
{
    public interface ITerrestrialRepository
    {
        List<Terrestrial> GetTerrestrials();  // Método para obtener todas las entidades "Terrestrial"
        Terrestrial GetTerrestrialById(Guid id);  // Método para obtener una entidad "Terrestrial" por ID
        Terrestrial GetTerrestrialByName(string name);  // Método para obtener una entidad "Terrestrial" por nombre
        void DeleteTerrestrial(Terrestrial terrestrial);  // Método para eliminar una entidad "Terrestrial"
    }
}
