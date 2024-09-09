using SpeciesApi.Models;
using System.Collections.Generic;

namespace SpeciesApi.Repositories.Interfaces
{
    public interface IAerialRepository
    {
        List<Aerial> GetAerials();  // Método para obtener todas las entidades "Aerial"
        Aerial GetAerialById(Guid id);  // Método para obtener una entidad "Aerial" por ID
        void DeleteAerial(Aerial aerial);  // Método para eliminar una entidad "Aerial"
        
    }
}
