namespace PokemonSimulator
{
    internal class Attack
    {
        public string Name { get; }
        public ElementType ElementType { get; }
        public int BasePower { get; }

        public Attack(string name, ElementType type, int basePower)
        { 
            Name = name;
            ElementType = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {
            Console.WriteLine($"{Name} hit with a total power of {BasePower + level}");

        }
    }
}
