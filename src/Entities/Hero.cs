namespace ProjectGFT3.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;            
        }
        public Hero()
        {
            
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com sua espada!";
        }
    }
}