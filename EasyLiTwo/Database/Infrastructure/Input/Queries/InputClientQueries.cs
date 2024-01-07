using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Input.Queries
{
    public class InputClientQueries : BaseQuery
    {

        private object GetEntityClienteAsAnonymous(ClientEntity entity)
        {
            return new
            {
                Guid = entity.Code.ToString(),
                Name = entity.Username,
                entity.Birth,
                entity.Email,
                RegDate = entity.Reg,
                entity.SHA,
                Status = (int)entity.UserState
            };
        }

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

            Parameters = GetEntityClienteAsAnonymous(entity);
            return new QueryModel(Query, Parameters);
        }

        public QueryModel UpdateClientQuery(ClientEntity entity)
        {
            Table = Map.GetClientTable();
            Query = $@"
            UPDATE {Table}
            SET         
                Name = @Name,
                Birth = @Birth,
                Email = @Email,
                RegDate = @RegDate,
                SHA = @SHA,
                Status = @Status        
            WHERE Guid = @Guid";

            Parameters = GetEntityClienteAsAnonymous(entity);
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
