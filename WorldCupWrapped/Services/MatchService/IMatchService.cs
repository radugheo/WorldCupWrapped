using WorldCupWrapped.Models.DTOs.Match;

namespace WorldCupWrapped.Services.MatchService
{
    public interface IMatchService
    {
        Task<List<MatchDto>> GetAllMatches();

        Task<List<MatchDto>> GetMatchesByGroup(string group);
    }
}
