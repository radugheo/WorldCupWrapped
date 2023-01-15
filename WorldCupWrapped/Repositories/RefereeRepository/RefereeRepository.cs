using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.RefereeRepository
{
    public class RefereeRepository: GenericRepository<Referee>, IRefereeRepository
    {
        public RefereeRepository(ProjectContext context) : base(context)
        {
        }

        public Referee GetRefereeFromMatchId(int matchId)
        {
            return _context.MatchReferees.Find(matchId).Referee;
        }
    }
}
