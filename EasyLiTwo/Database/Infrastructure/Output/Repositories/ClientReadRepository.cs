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
    internal class ClientReadRepository : IReadClientRepository
    {
        private readonly IDbConnection _connection;

        public ClientReadRepository(ISqlFactory factory)
        {
            _connection = factory.GetConnection();
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var query = new OutputClientQueries().GetAll();

            try
            {
                using (_connection)
                {
                    List<ClientDTO> results = _connection.Query<ClientDTO>(query.Query, query.Parameters) as List<ClientDTO>;
                    return results;
                }
            }
            catch
            {
                throw new Exception("Erro ao obter dados dos clientes");
            }
        }

        public ClientDTO GetClientByGuid(string clientGuid)
        {
            var query = new OutputClientQueries().GetClientBuGuid(clientGuid);

            try
            {
                using (_connection)
                {
                    List<ClientDTO> results = _connection.Query<ClientDTO>(query.Query, query.Parameters) as List<ClientDTO>;
                    if (results.Count > 0)
                    {
                        return results[0];
                    }
                    else
                        return null;
                }
            }
            catch
            {
                throw new Exception("Erro ao obter dados do cliente");
            }
        }
    }
}
