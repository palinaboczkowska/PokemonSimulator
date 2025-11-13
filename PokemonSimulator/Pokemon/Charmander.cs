
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
            //I github historiken finns en lösning utan listan med evolutioner

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
