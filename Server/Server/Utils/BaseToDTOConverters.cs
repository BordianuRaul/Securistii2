using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class BaseToDTOConverters
    {
        public static LocationDTO Converter_LocationToDTO(Location location) => new LocationDTO { Id = location.Id, Name = location.Name, Latitude = location.Latitude, Longitude = location.Longitude };
    }
}
