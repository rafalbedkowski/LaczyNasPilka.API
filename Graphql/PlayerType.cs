using GraphQL.Types;
using SoccerPlayer.Api.Models.Dtos;

namespace SoccerPlayer.Api.Graphql
{
    public class PlayerType : ObjectGraphType<PlayerDto>
    {
        public PlayerType()
        {
            Field(x => x.FirstName).Description("Imię");
            Field(x => x.LastName).Description("Nazwisko");
            Field(x => x.PlayerAge).Description("Wiek");
            Field(x => x.CurrentClub).Description("Obecny klub");
            Field(x => x.MatchesPlayed).Description("Rozegranych meczy");
            Field(x => x.MinutesOnThePitch).Description("Minuty na boisku");
            Field(x => x.Goals).Description("Bramki");
            Field(x => x.YellowCards).Description("Żółte kartki");
            Field(x => x.RedCards).Description("Czerwone kartki");
            Field<ListGraphType<ClubType>>("clubs", "Poprzednie kluby");
        }
    }
}