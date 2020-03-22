using GraphQL;
using GraphQL.Types;

namespace SoccerPlayer.Api.Graphql
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}