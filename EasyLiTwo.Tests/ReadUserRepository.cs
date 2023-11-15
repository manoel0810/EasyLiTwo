using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;

namespace EasyLiTwo.Tests
{
    public class ReadUserRepository
    {
        private readonly UserReadRepository getUserByNicknameRepository;

        public ReadUserRepository()
        {
            getUserByNicknameRepository = new(new Sqlite());
        }

        [Fact]
        public void GetUserByNicknameEmpty()
        {
            Assert.Empty(getUserByNicknameRepository.GetUserByNickname(""));
        }

        [Fact]
        public void GetUserByNicknameNull()
        {
            Assert.True(getUserByNicknameRepository.GetUserByNickname(null) == null);
        }

        [Fact]
        public void GetUserByNicknameExisting()
        {
            Assert.True(getUserByNicknameRepository.GetUserByNickname("derick").Count() > 0);
        }
    }
}