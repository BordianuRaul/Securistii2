using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class DTOToBaseConverters
    {
        public static Location Converter_DTOToLocation(LocationDTO locationDTO) => new Location { Id = locationDTO.Id, Name = locationDTO.Name, Latitude = locationDTO.Latitude, Longitude = locationDTO.Longitude };
    
        public static Post Converter_DTOToPost(PostDTO postDTO) => new Post { Post_Id = postDTO.Post_Id, Owner_User_Id = postDTO.Owner_User_Id, Description = postDTO.Description, Commented_Post_Id = postDTO.Commented_Post_Id, Original_Post_Id = postDTO.Original_Post_Id, Media_Path = postDTO.Media_Path, Post_Type = postDTO.Post_Type, Location_Id = postDTO.Location_Id, Created_Date = postDTO.Created_Date };
    }
}
