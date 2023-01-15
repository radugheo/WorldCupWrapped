using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.RefereeRepository
{
    public interface IRefereeRepository: IGenericRepository<Referee>
    {
        Referee GetRefereeFromMatchId(int matchId);
    }
}
