using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Input.Queries
{
    public class NewUserQuery : BaseQuery
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
                @NAME,
                @EMAIL,
                @USER_TYPE,
                @USER_STATE
            )
            ";

            Parameters = new
            {
                USERNAME = user.Username,
                SHA = user.SHA,
                NAME = user.Name,
                EMAIL = user.Email,
                USER_TYPE = (int)user.UserType,
                USER_STATE = (int)user.UserState,
            };

            return new QueryModel(Query, Parameters);
        }
    }
}
