using SpeciesApi.Models;

namespace SpeciesApi.Services.Intarfaces
{
    public interface IAerialServices
    {
        List<Aerial> GetAerialsBySpecies(string species);
        List<Aerial> GetAerialsByHabitat(string habitat);
        Aerial GetAerialByName(string name);
        void DeleteAerialByName(string name);



        Aerial GetAerialById(Guid id);
        void DeleteAerial(Guid id);

    }
}
