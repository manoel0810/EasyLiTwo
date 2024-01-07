using EasyLiTwo.Database.Infrastructure.Factory;
using EasyLiTwo.Database.Infrastructure.Output.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EasyLiTwoTests
{
    [TestClass]
    public class ReadUserRepository
    {
        private readonly UserReadRepository _repository;

        public ReadUserRepository()
        {
            _repository = new UserReadRepository(new Sqlite());
        }

        [TestMethod]
        public void GetUserByNicknameEmpty()
        {
            Assert.IsTrue(_repository.GetUserByNickname("").Any() == false);
        }

        [TestMethod]
        public void GetUserByNicknameNull()
        {
            Assert.IsTrue(_repository.GetUserByNickname(null) == null);
        }

        [TestMethod]
        public void GetUserByNicknameExisting()
        {
            Assert.IsTrue(_repository.GetUserByNickname("derick").Count() != 0);
        }
    }
}
