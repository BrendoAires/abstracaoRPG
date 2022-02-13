namespace RPG.src.Entities
{
    public class Dragon : Opponent
    {
        public Dragon(string Name, int Level, string OpponentType, int Damage, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.OpponentType = OpponentType;
            this.Damage = Damage;
            this.HP = HP;
        }   
        public string Name;
        public int Level;
        public string OpponentType;
        public int Damage;


        public virtual string Attack(){
            return this.Name + " Attacked";
        }

        public virtual string ReceivedDamage(){
            return this.Name + " Defended";
        }
        

    }
}