

namespace PokemonSimulator
{
    internal abstract class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name, int level, List<Attack> attacks) : base(name, level, attacks)
        {
            ElementType = ElementType.Grass;
        }
    }
}
