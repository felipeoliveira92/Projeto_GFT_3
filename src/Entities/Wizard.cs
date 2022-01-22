namespace ProjectGFT3.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;            
        }

        public override string Attack()
        {
            return this.Name + "Lançou sua magia!";
        }

        public string Attack(int bonus)
        {
            if(bonus > 5)
            {                
                return this.Name + "Lançou sua magia com Bonus" + bonus;

            }
            else
            {                
                return this.Name + "Lançou sua magia com Bonus";
            }
        }
        
    }
}