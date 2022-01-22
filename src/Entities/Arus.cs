namespace ProjectGFT3.src.Entities
{
    public class Arus
    {
        public Arus(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;            
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
    }
}