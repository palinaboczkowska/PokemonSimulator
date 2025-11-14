


namespace PokemonSimulator
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        private int _evolveAtLevel = 36;
        public Charmeleon(int level, List <Attack> attacks)
         : base("Charmeleon", level, attacks) { }


        public Pokemon Evolve() => new Charizard(Level, Attacks);

        public override void Speak()
        {
            Console.WriteLine("Charmeleon says: Charme charme!");
        }

        // Override RaiseLevel to check for evolution
        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel(); //increase level normally
            if (Level >= _evolveAtLevel)
            {
                Console.WriteLine($"{Name} is evolving into Charizard!");
                return Evolve();
            }
            return this; //no evolition yet
        }
    }
}
