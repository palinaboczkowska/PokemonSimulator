using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemon
{
    internal class Charmander : FirePokemon, IEvolvable //kan utvecklas
    {
        // Lista över möjliga evolutioner i ordning. Här används tre steg av utveckling
        //Jag vet inte om det var tänkt på så sätt enligt uppgiften
        private List<string> _evolutionStages = new List<string>
        { 
            "Charmander", //startnamn
            "Charmeleon",
            "Charizard"
        };
        // Index som håller reda på vilken utvecklingsfas Pokemon befinner sig i
        private int _currentStageIndex = 0;
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
            // Sätter namnet till den första evolution
            Name = _evolutionStages[_currentStageIndex];
        }



        public void Evolve()
        {
            //Lösning utan lista med evolutioner
            //Level += 10;
            //if (Name == "Charmander")
            //{
            //    Name = "Charmeleon";
            //    Console.WriteLine("Charmander har utvecklats.. Nu är det Charmeleon");
            //}
            //else if (Name == "Charmeleon")
            //{
            //    Name = "Charizard";
            //    Console.WriteLine("Charmeleon har utvecklats.. Nu är det Charizard");
            //}
            //else
            //    Console.WriteLine($"{Name} är redan i sin slutgiltiga form.");

            Level += 10; // alltid öka nivå, även om Pokemon är redan i sin slutgiltig form
            // Kontrollera om det finns en nästa utvecklingsfas
            if (_currentStageIndex < _evolutionStages.Count - 1)
            {
                _currentStageIndex++; //nästa fas
                Name = _evolutionStages[_currentStageIndex];
                Console.WriteLine($"{_evolutionStages[_currentStageIndex - 1]} har utvecklats.. Nu är det {Name} och dess nivå är {Level}");
            }
            else
                //Om Charizard
                Console.WriteLine($"{Name} är redan i sin slutgiltiga form.");

        }
    }
}
