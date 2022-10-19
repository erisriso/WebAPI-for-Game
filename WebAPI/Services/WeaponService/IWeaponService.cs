using WebAPI.Dtos.Character;
using WebAPI.Dtos.Weapon;

namespace WebAPI.Services.WeaponService;

public interface IWeaponService
{
    Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
}