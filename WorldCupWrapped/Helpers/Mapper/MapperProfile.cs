using AutoMapper;
using WorldCupWrapped.Models;
using WorldCupWrapped.Models.DTOs.Player;

namespace WorldCupWrapped.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<PlayerDto, Player>();
        }
    }
}
