

namespace PokemonSimulator
{
    internal abstract class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks) : base(name, level, attacks)
        {
            ElementType = ElementType.Water;
        }
    }
}
