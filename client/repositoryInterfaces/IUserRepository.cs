using client.models;

namespace client.repositories
{
    interface IUserRepository
    {
        List<User> getAllUsers();
        User getUserById(Guid id);
    }
}