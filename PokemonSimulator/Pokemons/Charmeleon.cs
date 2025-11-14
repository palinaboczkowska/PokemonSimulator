


namespace PokemonSimulator
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        public Charmeleon(int level, List <Attack> attacks)
         : base("Charmeleon", level, attacks) { }


        public Pokemon Evolve()
        {
            Console.WriteLine("Charmeleon is evolving into Charizard!");
            return new Charizard(Level, Attacks);

        }

        public override void Speak()
        {
            Console.WriteLine("Charmeleon says: Chaaar!");
        }
    }
}
