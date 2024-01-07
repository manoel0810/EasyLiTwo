using EasyLiTwo.Database.Domain.Entities;

namespace EasyLiTwo.Database.Input.Repositories
{
    public interface IWriteClientRepository
    {
        void InsertClient(ClientEntity entity);
        void UpdateClient(ClientEntity entity);
        void DeleteClient(string guid);
    }
}
