namespace PokemonSimulator.Pokemon
{
    internal class Bulbasaur : GrassPokemon
    {
        public Bulbasaur(int level, List<Attack> attacks) : base("Bulbasaur", level, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Bulba!");
        }
    }
}
