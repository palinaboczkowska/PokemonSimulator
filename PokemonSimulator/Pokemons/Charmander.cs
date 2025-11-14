

namespace PokemonSimulator
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        private int _evolveAtLevel = 16;
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

        public Pokemon Evolve() => new Charmeleon(Level, Attacks);
     

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Char char!");
        }

        // Override RaiseLevel to check for evolution
        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel(); //increase level normally
            if (Level >= _evolveAtLevel) 
            {
                Console.WriteLine($"{Name} is evolving into Charmeleon!");
                return Evolve();
            }
            return this; //no evolition yet
        }
    }
}
