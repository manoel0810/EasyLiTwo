using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Input.Queries
{
    public class InputClientQueries : BaseQuery
    {
        public QueryModel InsertClientQuery(ClientEntity entity)
        {
            Table = Map.GetClientTable();
            Query = $@"
            INSERT INTO {Table}
            VALUES
            (
                @Guid,
                @Name,
                @Birth,
                @Email,
                @RegDate,
                @SHA,
                @Status
            )
            ";

            Parameters = new
            {
                Guid = entity.Code.ToString(),
                Name = entity.Username,
                entity.Birth,
                entity.Email,
                RegDate = entity.Reg,
                entity.SHA,
                Status = entity.UserState
            };

            return new QueryModel(Query, Parameters);
        }

        public QueryModel DeleteClientQuery(string guid)
        {
            Table = Map.GetClientTable();
            Query = $@"

            DELETE FROM {Table}
            WHERE Guid = @Guid
            ";

            Parameters = new
            {
                Guid = guid
            };

            return new QueryModel(Query, Parameters);
        }
    }
}
