using SoccerPlayer.Api.Models.Dtos;

namespace SoccerPlayer.Api.IRepository
{
    public interface IPlayerRepository
    {
        PlayerDto GetData(string userUrl);
    }
}