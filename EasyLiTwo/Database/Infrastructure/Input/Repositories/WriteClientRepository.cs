using Dapper;
using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Input.Queries;
using EasyLiTwo.Database.Input.Repositories;
using System;
using System.Data;

namespace EasyLiTwo.Database.Infrastructure.Input.Repositories
{
    internal class WriteClientRepository : IWriteClientRepository
    {
        private readonly IDbConnection _connection;

        public WriteClientRepository(ISqlFactory factory)
        {
            _connection = factory.GetConnection();
        }

        public void InsertClient(ClientEntity entity)
        {
            var query = new InputClientQueries().InsertClientQuery(entity);

            try
            {
                using (_connection)
                {
                    _connection.Execute(query.Query, query.Parameters);
                }
            }
            catch
            {
                throw new Exception($"Erro ao registrar cliente");
            }
        }
    }
}
