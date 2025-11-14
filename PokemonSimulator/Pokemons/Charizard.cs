
namespace PokemonSimulator
{
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