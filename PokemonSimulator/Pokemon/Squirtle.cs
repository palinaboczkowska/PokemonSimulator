using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemon
{
    internal class Squirtle : WaterPokemon
    {
        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks)
        {
        }
    }
}
