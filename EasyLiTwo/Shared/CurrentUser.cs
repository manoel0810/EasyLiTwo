using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Enums;

namespace EasyLiTwo.Shared
{
    public class CurrentUser
    {
        private static UserEntity _entity;

        public static void SetUser(UserEntity entity)
        {
            _entity = entity;
        }

        public static User GetUserPublicInformation() => new User(_entity);

        public class User
        {
            public string Name { get; private set; }
            public string Email { get; private set; }
            public string SHA { get; private set; }
            public UserType UserType { get; private set; }

            public User(UserEntity entity)
            {
                if (entity == null)
                    return;

                Name = entity.Name;
                Email = entity.Email;
                SHA = entity.SHA;
                UserType = entity.UserType;
            }
        }
    }
}
