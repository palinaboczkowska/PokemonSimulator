
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
                    throw new ArgumentException("Level måste vara minst 1.");
                _level = value;

            }
        }
        public ElementType ElementType { get; set; } //set protected?
        public List<Attack> Attacks { get; set; } //set inte behövs?

        protected Pokemon(string name, int level, List<Attack> attacks) 
        {
            Name = name;
            Level = level;
            Attacks = attacks; //null exception?
        }

        public void RandomAttack()
        { 
        
        }

        public void Attack()
        { 
        
        }

        public void RaiseLevel()
        { 
        
        }


    
    }
}
