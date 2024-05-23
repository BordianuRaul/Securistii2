using NuGet.Protocol.Plugins;
using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class BaseToDTOConverters
    {
        public static UserDTO Converter_UserToDTO(User user) => new UserDTO { Id = user.Id, Username = user.Username, ProfilePicturePath = user.ProfilePicturePath };
        public static MediaDTO Converter_MediaToDTO(Media media) => new MediaDTO { Id = media.Id, FilePath = media.FilePath };
        public static LocationDTO Converter_LocationToDTO(Location location) => new LocationDTO { Id = location.Id, Name = location.Name, Latitude = location.Latitude, Longitude = location.Longitude };

        public static PostArchivedDTO Converter_PostArchivedToDTO(PostArchived postArchived) => new PostArchivedDTO { post_id = postArchived.post_id, archive_id = postArchived.archive_id };
        public static PostSavedDTO Converter_PostSavedToDTO(PostSaved postSaved) => new PostSavedDTO { save_id = postSaved.save_id, post_id = postSaved.post_id, user_id = postSaved.user_id };

        public static PostDTO Converter_PostToDTO(Post post) => new PostDTO { Post_Id = post.Post_Id, Owner_User_Id = post.Owner_User_Id, Description = post.Description, Commented_Post_Id = post.Commented_Post_Id, Original_Post_Id = post.Original_Post_Id, Media_Path = post.Media_Path, Post_Type = post.Post_Type, Location_Id = post.Location_Id, Created_Date = post.Created_Date };
        public static BlockDTO Converter_BlockToDTO(Block block) => new BlockDTO { Id = block.Id, sender = block.sender, receiver = block.receiver, startingTimeStamp = block.startingTimeStamp,  reason = block.reason };
        public static FollowDTO Converter_FollowToDTO(Follow follow) => new FollowDTO { Id = follow.Id, sender = follow.sender, receiver = follow.receiver, isCloseFriend = follow.isCloseFriend, expirationTimeStamp = follow.expirationTimeStamp, description = follow.description };
    }
}
