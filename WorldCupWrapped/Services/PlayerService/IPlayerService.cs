using WorldCupWrapped.Models.DTOs.Player;

namespace WorldCupWrapped.Services.PlayerService
{
    public interface IPlayerService
    {
        Task<List<PlayerDto>> GetAllPlayers();
    }
}
