using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;

namespace EasyLiTwo.Tests.MS
{
    [TestClass]
    public class GetUserByNicknameTeste
    {
        [TestMethod]
        public void GetUserByNicknameExisting()
        {
            GetUserByNicknameRepository getUserByNicknameRepository = new(new Sqlite());
            Assert.IsTrue(getUserByNicknameRepository.GetUserByNickname("derick").Rows.Count > 0);
        }
    }
}