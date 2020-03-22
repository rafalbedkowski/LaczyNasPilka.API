using GraphQL.Types;
using SoccerPlayer.Api.Models.Dtos;

namespace SoccerPlayer.Api.Graphql
{
    public class ClubType : ObjectGraphType<ClubDto>
    {
        public ClubType()
        {
            Field(x => x.Season).Description("Sezon");
            Field(x => x.Name).Description("Nazwa klubu");
        }

    }
}