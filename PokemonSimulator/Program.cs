
using PokemonSimulator;

Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
Attack ember = new Attack("Ember", ElementType.Fire, 6);
Attack waterGun = new Attack("Water Gun", ElementType.Water, 5);
Attack aquaTail = new Attack("Aqua Tail", ElementType.Water, 7);
Attack leafBlade = new Attack("Leaf Blade", ElementType.Grass, 4);
Attack powerWhip = new Attack("Power Whip", ElementType.Grass, 11);

// Legendary attacks are automatically created inside GetEffectiveAttack()
//LegendaryAttack legendaryEmber = new LegendaryAttack(ember, 15);
//LegendaryAttack legendaryWaterGun = new LegendaryAttack(waterGun, 15);
//LegendaryAttack legendaryLeafBlade = new LegendaryAttack(leafBlade, 15);



Charmander charmander = new Charmander(8, new List<Attack> { flamethrower, ember});
Squirtle squirtle = new Squirtle(7, new List<Attack>() { waterGun});
Bulbasaur bulbasaur = new Bulbasaur(11, new List<Attack> { leafBlade});

List<Pokemon> pokemons = new List<Pokemon>
{
    charmander,
    squirtle,
    bulbasaur
};

foreach (var original in pokemons)
{
    Pokemon current = original;

    Console.WriteLine($"\n--- Starting with {current.Name} ---");

    // Initial behavior
    current.Speak();
    current.Attack();

    // Simulate level-ups
    for (int i = 0; i < 30; i++) // enough to trigger evolution
    {
        current = current.RaiseLevel(); // evolution happens inside RaiseLevel()
    }

    Console.WriteLine($"\n--- After leveling ---");
    Console.WriteLine($"Current form: {current.Name}, Level: {current.Level}");
    current.Speak();
    current.Attack();
}
