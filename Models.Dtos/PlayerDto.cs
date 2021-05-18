using System.Collections.Generic;

namespace SoccerPlayer.Api.Models.Dtos
{
    public class PlayerDto
    {
        public PlayerDto()
        {
            Clubs = new HashSet<ClubDto>();
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerAge { get; set; }
        public string CurrentClub { get; set; }
        public int MatchesPlayed { get; set; }
        public int MinutesOnThePitch { get; set; }
        public int Goals { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public ICollection<ClubDto> Clubs { get; set; }
    }
}