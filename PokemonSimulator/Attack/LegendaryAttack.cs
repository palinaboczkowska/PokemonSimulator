using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Attack
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack baseAttack) : base(baseAttack.Name, baseAttack.ElementType, baseAttack.BasePower)
        {
        }

        public override void Use(int level)
        {
            Console.WriteLine($"{Name} unleashes its potential with total power {BasePower + level * 2}");    
        }

    }
}
