using GraphQL.Types;
using SoccerPlayer.Api.IRepository;

namespace SoccerPlayer.Api.Graphql
{
    public class AppQuery : ObjectGraphType
    {
        private readonly IPlayerRepository _repo;

        public AppQuery(IPlayerRepository repository)
        {
            _repo = repository;

            Field<PlayerType>(
                "player",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userUrl" }),
                resolve: context =>
                {
                    var url = context.GetArgument<string>("userUrl");
                    return _repo.GetData(url);
                }
            );
        }
    }
}