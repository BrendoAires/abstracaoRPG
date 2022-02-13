namespace RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Nome, int Level, string HeroType, int Damage)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Damage = Damage;
        }

        public virtual string Attack(){
            return this.Name + " Attacked";
        }

        public virtual string ReceivedDamage(){
            return this.Name + " Defended";
        }

    }
}