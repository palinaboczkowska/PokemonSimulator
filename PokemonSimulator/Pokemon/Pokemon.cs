
namespace PokemonSimulator.Pokemon
{
    internal abstract class Pokemon
    {
        private string _name;
        private int _level;

        public string Name { get; set; } //lägga till validering för 2-15 tecken
        
        public int Level { get; set; }//lägga till validering för >=1
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
