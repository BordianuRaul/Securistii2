using client.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using client.models;
using client.servicesInterfaces;

namespace client.services
{
    class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User getUserById(Guid id)
        {
            return _userRepository.getUserById(id);
        }

        public List<User> getAllUsers()
        {
            return _userRepository.getAllUsers();
        }
    }
}
