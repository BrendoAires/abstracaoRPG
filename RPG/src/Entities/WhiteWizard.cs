namespace RPG.src.Entities
{
    public class WhiteWizard : Hero
    {

        public WhiteWizard(string Name, int Level, string HeroType, int Damage)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Damage = Damage;
        }

        
        public override string Attack(){
            return this.Name + "Lançou a magia";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + "Lançou magia super efetiva com bônus de ataque " + Bonus;
            
            } else{
                return this.Name + " Lançou magia com força fraca com bônus de " + Bonus;
            }
            
        }

        
    }
}