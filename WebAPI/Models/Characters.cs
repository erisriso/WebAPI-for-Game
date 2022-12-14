namespace WebAPI.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frobo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public User? User { get; set; }
        public Weapon Weapon { get; set; }
        public List<Skill> Skill { get; set; }
    }
}
