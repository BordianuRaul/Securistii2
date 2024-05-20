using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class DTOToBaseConverters
    {
        public static Location Converter_DTOToLocation(LocationDTO locationDTO) => new Location { Id = locationDTO.Id, Name = locationDTO.Name, Latitude = locationDTO.Latitude, Longitude = locationDTO.Longitude };
    }
}
