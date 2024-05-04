using client.models;

namespace client.servicesInterfaces
{
    interface IUserService
    {
        List<User> getAllUsers();
        User getUserById(Guid id);
    }
}