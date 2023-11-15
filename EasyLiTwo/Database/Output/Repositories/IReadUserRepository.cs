using EasyLiTwo.Database.Output.DTOs;
using System.Collections.Generic;

namespace EasyLiTwo.Database.Output.Repositories
{
    public interface IReadUserRepository
    {
        IEnumerable<UserDTO> GetUserByNickname(string nickName);

        IEnumerable<UserDTO> GetUserBySHA(string SHA);
    }
}
