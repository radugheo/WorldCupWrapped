using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Models;
using WorldCupWrapped.Models.DTOs.Team;
using WorldCupWrapped.Models.DTOs.Trophy;
using WorldCupWrapped.Models.DTOs.TrophyCount;
using WorldCupWrapped.Repositories.TeamRepository;

namespace WorldCupWrapped.Services.TeamService
{
    public class TeamService : ITeamService
    {

        public ITeamRepository _teamRepository;
        public IMapper _mapper;
        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public async Task<List<TeamDto>> GetTeamsByGroup(string group)
        {
            var teams = await _teamRepository.GetTeamsByGroup(group);
            var result = _mapper.Map<List<TeamDto>>(teams);

            return result;
        }
        public async Task<List<TeamDto>> GetTeamsByGroupAndPosition(string group, string position)
        {
            var teams = await _teamRepository.GetTeamsByGroupAndPosition(group, position);
            var result = _mapper.Map<List<TeamDto>>(teams);

            return result;
        }
        public async Task<List<TeamDto>> GetAllTeams()
        {
            var teams = await _teamRepository.GetAllTeams();
            var result = _mapper.Map<List<TeamDto>>(teams);

            return result;
        }
        public async Task<List<TrophyCountDto>> GetTeamTrophies(string teamName)
        {
            var trophies = await _teamRepository.GetTeamTrophies(teamName);
            var result = _mapper.Map<List<TrophyCountDto>>(trophies);
            
            return result;
        }
    }
}
