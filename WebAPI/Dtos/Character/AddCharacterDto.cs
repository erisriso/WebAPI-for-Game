namespace WebAPI.Dtos.Character
{
    public class AddCharactersDto
    {
        public string Name { get; set; } = "Frobo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass RpgClass { get; set; } = RpgClass.Knight;
    }
}
