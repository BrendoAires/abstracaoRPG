namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Damage){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Damage = Damage;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int Damage;



       

        
        
    }
}