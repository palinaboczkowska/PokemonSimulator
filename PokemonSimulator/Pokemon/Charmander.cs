
namespace PokemonSimulator.Pokemon
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        // Ordered list of evolution stages: Charmander - Charmeleon - Charizard
        private List<string> _evolutionStages = new List<string>
        {
            "Charmander", //initial name
            "Charmeleon",
            "Charizard"
        };
        // Index to track the current evolution stage
        private int _currentStageIndex = 0;
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks)
        {
            // Set the name to the first evolution stage
            Name = _evolutionStages[_currentStageIndex];
        }


        public void Evolve()
        {
            // There is a solution in the GitHub history that doesn't use a list of evolutions

            // Always increase level, even if already fully evolved
            Level += 10;
            // Check if there is a next evolution stage
            if (_currentStageIndex < _evolutionStages.Count - 1)
            {
                _currentStageIndex++; //next stage
                Name = _evolutionStages[_currentStageIndex];
                Console.WriteLine($"{_evolutionStages[_currentStageIndex - 1]} is evolving...Now it is a {Name} and its level is {Level}");
            }
            else
                //Already at final form (Charizard)
                Console.WriteLine($"{Name} is already in its final form.");
        }
    }
}
