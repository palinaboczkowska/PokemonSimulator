namespace PokemonSimulator.Pokemon
{
    internal class Squirtle : WaterPokemon
    {
        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Squirt squirt!");
        }
    }
}
