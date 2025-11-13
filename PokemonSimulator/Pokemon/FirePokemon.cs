namespace PokemonSimulator.Pokemon
{
    internal class FirePokemon: Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks):base(name, level, attacks) 
        {
        ElementType = ElementType.Fire;
        }
        
    }
}
