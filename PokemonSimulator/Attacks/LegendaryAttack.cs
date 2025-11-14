using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{

    internal class LegendaryAttack : Attack
    {
        // Minimum level required to use this legendary attack
        private readonly int _requiredLevel;
        public LegendaryAttack(Attack baseAttack, int requiredLevel = 10)
            : base(baseAttack.Name, baseAttack.ElementType, baseAttack.BasePower)
        {
            _requiredLevel = requiredLevel;
        }

        public override void Use(int level)
        {
            // Prevent use if Pokemon hasn't reached the required level
            if (level < _requiredLevel)
            {
                Console.WriteLine($"{Name} is too powerful to use below level {_requiredLevel}.");
                return;
            }

            Console.WriteLine($"{Name} unleashes its potential with total power {BasePower + level * 2}");    
        }

    }
}
