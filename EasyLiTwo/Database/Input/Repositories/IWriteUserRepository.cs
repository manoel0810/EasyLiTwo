using EasyLiTwo.Database.Domain.Entities;

namespace EasyLiTwo.Database.Input.Repositories
{
    public interface IWriteUserRepository
    {
        void InsertUser(UserEntity user);
    }
}
