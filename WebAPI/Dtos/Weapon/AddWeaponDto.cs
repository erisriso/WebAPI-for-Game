namespace WebAPI.Dtos.Weapon;

public class AddWeaponDto
{
    public string Name { get; set; } = string.Empty;
    public int Damage { get; set; }
    public int CharactersId { get; set; }
}