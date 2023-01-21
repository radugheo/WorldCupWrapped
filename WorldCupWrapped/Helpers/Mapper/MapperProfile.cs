using AutoMapper;
using WorldCupWrapped.Models;
using WorldCupWrapped.Models.DTOs.Manager;
using WorldCupWrapped.Models.DTOs.Player;
using WorldCupWrapped.Models.DTOs.Stadium;
using WorldCupWrapped.Models.DTOs.Team;
using WorldCupWrapped.Models.DTOs.Trophy;

namespace WorldCupWrapped.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Manager, ManagerDto>();
            CreateMap<ManagerDto, Manager>();
            CreateMap<Team, TeamDto>();
            CreateMap<TeamDto, Team>();
            CreateMap<Player, PlayerDto>();
            CreateMap<PlayerDto, Player>();
            CreateMap<Trophy, TrophyDto>();
            CreateMap<TrophyDto, Trophy>();
            CreateMap<Stadium, StadiumDto>();
            CreateMap<StadiumDto, Stadium>();
        }
    }
}
