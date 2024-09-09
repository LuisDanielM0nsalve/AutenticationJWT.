using SpeciesApi.Models;
using System;
using System.Collections.Generic;

namespace SpeciesApi.Repositories.Interfaces
{
    public interface IAquaticRepository
    {
        List<Aquatic> GetAquatics();  // Método para obtener todas las entidades "Aquatic"
        Aquatic GetAquaticById(Guid id);  // Método para obtener una entidad "Aquatic" por ID
        Aquatic GetAquaticByName(string name);  // Método para obtener una entidad "Aquatic" por nombre
        void DeleteAquatic(Aquatic aquatic);  // Método para eliminar una entidad "Aquatic"
    }
}
