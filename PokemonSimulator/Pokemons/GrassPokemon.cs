using PokemonSimulator.Attacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
