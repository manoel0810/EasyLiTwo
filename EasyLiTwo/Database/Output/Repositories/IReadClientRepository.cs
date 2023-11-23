using EasyLiTwo.Database.Output.DTOs;
using System.Collections.Generic;

namespace EasyLiTwo.Database.Output.Repositories
{
    public interface IReadClientRepository
    {
        IEnumerable<ClientDTO> GetAll();
        ClientDTO GetClientByGuid(string clientGuid);
    }
}
