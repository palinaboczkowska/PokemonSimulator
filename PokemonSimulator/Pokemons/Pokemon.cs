
namespace PokemonSimulator
{
    internal abstract class Pokemon
    {
        private string _name;
        private int _level;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must be between 2 and 15 characters long.");
                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Level must be at least 1.");
                _level = value;
            }
        }
        public ElementType ElementType { get; protected set; }
        public List<Attack> Attacks { get; }

        protected Pokemon(string name, int level, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Attacks = attacks ?? throw new ArgumentNullException(nameof(attacks));
        }

        // Returns the legendary version of an attack based on the Pokemon's level
        // If the level is high enough, the attack is automatically upgraded to legendary
        protected virtual Attack GetLegendaryAttack (Attack baseAttack)
        {
            if (Level >= 10) //supposing
                return new LegendaryAttack(baseAttack, 10);

            return baseAttack;

        }

        public void RandomAttack()
        {
            if (Attacks == null || Attacks.Count == 0)
            {
                Console.WriteLine($"{Name} has no attacks to use.");
                return;
            }
            var random = new Random();
            var baseAttack = Attacks[random.Next(Attacks.Count)];
            // Automatically upgrade attack if level is high enough
            var legendaryAttack = GetLegendaryAttack(baseAttack);
            legendaryAttack.Use(Level);

        }

        public void Attack()
        {
            if (Attacks == null || Attacks.Count == 0)
            {
                Console.WriteLine($"{Name} has no attacks to use.");
                return;
            }
            Console.WriteLine($"Choose an attack for {Name}: ");
            for (int i = 0; i < Attacks.Count; i++)
                Console.WriteLine($"{i + 1}.{Attacks[i].Name}");
            int choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= Attacks.Count)
                {
                    var baseAttack = Attacks[choice - 1];

                    // Automatically upgrade attack if level is high enough
                    var legendaryAttack = GetLegendaryAttack(baseAttack);
                    legendaryAttack.Use(Level);
                    break;
                }
                else
                    Console.WriteLine("Invalid input. Please enter a valid attack number.");
            }
        }

        public virtual Pokemon RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} has leveled up to {Level}!");
            return this; //return current Pokemon
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} says ... ");
        }
    }
}
