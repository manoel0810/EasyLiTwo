using Dapper;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Input.Queries;
using EasyLiTwo.Database.Input.Repositories;
using System;
using System.Data;

namespace EasyLiTwo.Database.Infrastructure.Input.Repositories
{
    public class WriteUserRepository : IWriteUserRepository
    {
        private readonly IDbConnection _connection;

        public WriteUserRepository(ISqlFactory factory)
        {
            _connection = factory.GetConnection();
        }

        public void InsertUser(UserEntity user)
        {
            var query = new InputUserQueries().InsertUserQuery(user);

            try
            {
                using (_connection)
                {
                    _connection.Execute(query.Query, query.Parameters);
                }
            }
            catch
            {
                throw new Exception($"Erro ao registrar usuário");
            }
        }
    }
}
