using SpeciesApi.Utilities;

namespace SpeciesApi.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        // Propiedades comunes a todos los animales
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Weight { get; set; }

        // Propiedad que indica si el animal es doméstico o salvaje
        public bool IsDomesticated { get; set; }

        // Propiedad que describe el hábitat principal del animal
        public string Habitat { get; set; }
        public Reproduction Reproduction { get; set; }

    }
}
