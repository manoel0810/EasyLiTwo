using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Input.Queries
{
    public class InputUserQueries : BaseQuery
    {
        public QueryModel InsertUserQuery(UserEntity user)
        {
            Table = Map.GetAuthTable();
            Query = $@"
            INSERT INTO {Table}
            VALUES
            (
                @USERNAME,
                @SHA,
                @Name,
                @Email,
                @UserType,
                @UserState
            )
            ";

            Parameters = new
            {
                USERNAME = user.Username,
                user.SHA,
                user.Name,
                user.Email,
                UserType = (int)user.UserType,
                UserState = (int)user.UserState,
            };

            return new QueryModel(Query, Parameters);
        }
    }
}
