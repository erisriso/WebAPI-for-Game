using System.Security.Claims;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Dtos.Character;
using WebAPI.Dtos.Weapon;

namespace WebAPI.Services.WeaponService;

public class WeaponService : IWeaponService
{
    private readonly DataContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMapper _mapper;
    //private IWeaponService _weaponServiceImplementation;

    public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper;
    }
    
    public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
    {
        ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();
        try
        {
            Characters character = await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == newWeapon.CharactersId &&
                                          c.User.Id ==
                                          int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes
                                              .NameIdentifier)));
            if (character == null)
            {
                response.Success = false;
                response.Message = "Character not found";
                return response;
            }

            Weapon weapon = new Weapon
            {
                Name = newWeapon.Name,
                Damage = newWeapon.Damage,
                Characters = character
            };

            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();
            response.Data = _mapper.Map<GetCharacterDto>(character);
        }
        catch(Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }

        return response;
    }
}