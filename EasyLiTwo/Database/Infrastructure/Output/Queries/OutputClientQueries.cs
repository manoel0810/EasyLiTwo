using EasyLiTwo.Database.Infrastructure.Shared;

namespace EasyLiTwo.Database.Infrastructure.Output.Queries
{
    public class OutputClientQueries : BaseQuery
    {
        public QueryModel GetAll()
        {
            Table = Map.GetClientTable();
            Query = $@"
                
                SELECT * 
                FROM        
                {Table}
            ";

            return new QueryModel(Query, new object { });
        }

        public QueryModel GetClientBuGuid(string guid)
        {
            Table = Map.GetClientTable();
            Query = $@"
                
                SELECT * 
                FROM 
                {Table}
                WHERE
                Guid = @Code
                
            ";

            Parameters = new
            {
                Code = guid
            };

            return new QueryModel(Query, Parameters);
        }
    }
}
