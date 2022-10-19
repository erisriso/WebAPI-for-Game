using AutoMapper;
using WebAPI.Dtos.Character;
using WebAPI.Dtos.Skill;
using WebAPI.Dtos.Weapon;
using WebAPI.Models;

namespace WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Characters, GetCharacterDto>();
            CreateMap<AddCharactersDto, Characters>();
            CreateMap<UpdateCharacterDto, Characters>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
        
    }
}
