using client.models;

namespace client.servicesInterfaces
{
    internal interface ILocationService
    {
        Task<Location> GetLocationById(string locationId);
        Task<List<Location>> SearchLocations(string querry);
    }
}