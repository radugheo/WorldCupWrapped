using AutoMapper;
using WorldCupWrapped.Models.DTOs.Match;
using WorldCupWrapped.Repositories.MatchRepository;

namespace WorldCupWrapped.Services.MatchService
{
    public class MatchService : IMatchService
    {
        public IMatchRepository _matchRepository;
        public IMapper _mapper;
        public MatchService(IMatchRepository matchRepository, IMapper mapper)
        {
            _matchRepository = matchRepository;
            _mapper = mapper;
        }
        public async Task<List<MatchDto>> GetAllMatches()
        {
            var matches = await _matchRepository.GetAllMatches();
            var result = _mapper.Map<List<MatchDto>>(matches);

            return result;
        }

        public async Task<List<MatchDto>> GetMatchesByGroup(string group)
        {
            var matches = await _matchRepository.GetMatchesByGroup(group);
            var result = _mapper.Map<List<MatchDto>>(matches);

            return result;
        }
    }
}
