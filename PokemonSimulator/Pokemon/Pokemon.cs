
using System.Xml.Serialization;

namespace PokemonSimulator.Pokemon
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
                    throw new ArgumentException("Namnet måste vara mellan 2 och 15 tecken långt.");
                _name = value;
            }
        }
        
        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Nivån måste vara minst 1.");
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

        public void RandomAttack()
        {
            if (Attacks == null || Attacks.Count == 0)
            {
                Console.WriteLine($"{Name} har inga attacker att använda.");
                return;
            }
            var random = new Random();
            var attack = Attacks[random.Next(Attacks.Count)];
            attack.Use(Level);
        }

        public void Attack()
        {
            if (Attacks == null || Attacks.Count == 0)
            { 
                Console.WriteLine($"{Name} har inga attacker att använda.");
                return;
            }
            Console.WriteLine($"Välj en attack för {Name}: ");
            for (int i = 0; i < Attacks.Count; i++)
                Console.WriteLine($"{i + 1}.{Attacks[i].Name}");
            int choice;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= Attacks.Count)
                {
                    Attacks[choice - 1].Use(Level);
                    break;
                }
                else
                    Console.WriteLine("Ogiltig inmatning. Ange numret på attacken: ");
            }
        }

        public void RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} har ökat sin nivå till {Level}!");
        }


    
    }
}
