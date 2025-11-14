
namespace PokemonSimulator
{
    // Charizard is the final form and cannot evolve further
    internal sealed class Charizard : FirePokemon
    {
        public Charizard(int level, List<Attack> attacks)
         : base("Charizard", level, attacks) { }


        public override void Speak()
        {
            Console.WriteLine("Charizard says: RAWR!");
        }
    }
}