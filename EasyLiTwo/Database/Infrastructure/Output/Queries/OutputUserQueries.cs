using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Output.Queries
{
    public class OutputUserQueries : BaseQuery
    {
        public QueryModel GetUserQuery(string nikeName)
        {
            Table = Map.GetAuthTable();
            Query = $@"
            SELECT * FROM {Table}
            WHERE USERNAME = @USERNAME
            ";

            Parameters = new
            {
                USERNAME = nikeName
            };

            return new QueryModel(Query, Parameters);
        }

        public QueryModel GetUserBySHAQuery(string SHA)
        {
            Table = Map.GetAuthTable();
            Query = $@"
            SELECT * FROM {Table}
            WHERE SHA = @SHA
            ";

            Parameters = new
            {
                SHA
            };

            return new QueryModel(Query, Parameters);
        }
    }
}
