using client.models;

namespace client.repositories
{
    internal interface ILocationRepository
    {
        Task<Location> GetLocationDetails(string locationId);
        Task<List<Location>> SearchLocations(string query);
    }
}