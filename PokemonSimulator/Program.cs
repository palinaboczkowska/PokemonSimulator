
using PokemonSimulator;
using PokemonSimulator.Pokemon;

Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
Attack ember = new Attack("Ember", ElementType.Fire, 6);
Attack waterGun = new Attack("Water Gun", ElementType.Water, 5);
Attack leafBlade = new Attack("Leaf Blade", ElementType.Grass, 4);

Charmander charmander = new Charmander(1, new List<Attack> { flamethrower, ember});
Squirtle squirtle = new Squirtle(2, new List<Attack>() { waterGun });
Bulbasaur bulbasaur = new Bulbasaur(3, new List<Attack> { leafBlade });

List<Pokemon> pokemons = new List<Pokemon>
{
charmander,
squirtle,
bulbasaur
};

foreach (var pokemon in pokemons)
{
    try {
        pokemon.RaiseLevel();
        pokemon.Attack();

        if (pokemon is IEvolvable evolvable)
        { 
            evolvable.Evolve();
            evolvable.Evolve();
            evolvable.Evolve();
        }
    }
    catch (Exception ex)
    { 
        Console.WriteLine(ex);
    }
}





