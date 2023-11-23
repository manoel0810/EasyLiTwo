using Dapper;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Output.Queries;
using EasyLiTwo.Database.Output.DTOs;
using EasyLiTwo.Database.Output.Repositories;
using System;
using System.Collections.Generic;
using System.Data;

namespace EasyLiTwo.Database.Infrastructure.Output.Repositories
{
    public class UserReadRepository : IReadUserRepository
    {
        private readonly IDbConnection _connection;
        public UserReadRepository(ISqlFactory factory)
        {
            _connection = factory.GetConnection();
        }

        public IEnumerable<UserDTO> GetUserByNickname(string nickName)
        {
            var query = new OutputUserQueries().GetUserQuery(nickName);

            try
            {
                using (_connection)
                {
                    List<UserDTO> results = _connection.Query<UserDTO>(query.Query, query.Parameters) as List<UserDTO>;
                    return results;
                }
            }
            catch
            {
                throw new Exception("Erro ao obter dados do usuário por Nickname");
            }
        }

        public IEnumerable<UserDTO> GetUserBySHA(string SHA)
        {
            var query = new OutputUserQueries().GetUserBySHAQuery(SHA);

            try
            {
                using (_connection)
                {
                    List<UserDTO> results = _connection.Query<UserDTO>(query.Query, query.Parameters) as List<UserDTO>;
                    return results;
                }
            }
            catch
            {
                throw new Exception("Erro ao obter dados do usuário por HASH");
            }
        }
    }
}
