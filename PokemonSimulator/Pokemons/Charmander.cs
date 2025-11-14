

namespace PokemonSimulator
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


        public Pokemon Evolve()
        {
            Console.WriteLine($"{Name} is evolving into Charmeleon!");
            return new Charmeleon(Level, Attacks);
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Char char!");
        }
    }
}
