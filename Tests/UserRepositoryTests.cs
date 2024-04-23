using System;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using client.repositories;

namespace Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        private IUserRepository _userRepository;

        [SetUp]
        public void Setup()
        {
            _userRepository = new UserRepository();
        }

        [Test]
        public void GetUserByIdTest_FirstUser()
        {
            var user = _userRepository.getUserById(Guid.Parse("D5711B72-7E1F-4A8D-9226-38F6DA717A77"));
            Assert.IsNotNull(user);
            Assert.AreEqual(user.Id, Guid.Parse("D5711B72-7E1F-4A8D-9226-38F6DA717A77"));
            Assert.IsNotNull(user.Username);
            Assert.IsNotNull(user.ProfilePicturePath);
        }
        [Test]
        public void GetUserByIdTest_SecondUser() {
            var user = _userRepository.getUserById(Guid.Parse("D6666B72-7E1F-4A8D-9226-38F6DA717A77"));
            Assert.IsNotNull(user);
            Assert.AreEqual(user.Id, Guid.Parse("D6666B72-7E1F-4A8D-9226-38F6DA717A77"));
            Assert.IsNotNull(user.Username);
            Assert.IsNotNull(user.ProfilePicturePath);
        }
        [Test]
        public void GetUserByIdTest_InvalidUser() {
            var user = _userRepository.getUserById(Guid.Parse("D7777B72-7E1F-4A8D-9226-38F6DA717A77"));
            Assert.IsNull(user);
        }
    }
}
