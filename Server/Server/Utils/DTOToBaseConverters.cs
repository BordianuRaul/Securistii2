﻿using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class DTOToBaseConverters
    {
        public static User Converter_DTOToUser(UserDTO userDTO) => new User { Id = userDTO.Id, Username = userDTO.Username, ProfilePicturePath = userDTO.ProfilePicturePath };
        public static Media Converter_DTOToMedia(MediaDTO mediaDTO) => new Media { Id = mediaDTO.Id, FilePath = mediaDTO.FilePath };
        public static Location Converter_DTOToLocation(LocationDTO locationDTO) => new Location { Id = locationDTO.Id, Name = locationDTO.Name, Latitude = locationDTO.Latitude, Longitude = locationDTO.Longitude };
    
        public static Post Converter_DTOToPost(PostDTO postDTO) => new Post { Post_Id = postDTO.Post_Id, Owner_User_Id = postDTO.Owner_User_Id, Description = postDTO.Description, Commented_Post_Id = postDTO.Commented_Post_Id, Original_Post_Id = postDTO.Original_Post_Id, Media_Path = postDTO.Media_Path, Post_Type = postDTO.Post_Type, Location_Id = postDTO.Location_Id, Created_Date = postDTO.Created_Date };

        public static PostArchived Converter_DTOToPostArchived(PostArchivedDTO postArchivedDTO) => new PostArchived { post_id = postArchivedDTO.post_id, archive_id = postArchivedDTO.archive_id };
        public static PostSaved Converter_DTOToPostSaved(PostSavedDTO postSavedDTO) => new PostSaved { save_id = postSavedDTO.save_id, post_id = postSavedDTO.post_id, user_id = postSavedDTO.user_id };
        public static Block Converter_DTOToBlock(BlockDTO blockDTO) => new Block { Id = blockDTO.Id, sender = blockDTO.sender, receiver = blockDTO.receiver, startingTimeStamp = blockDTO.startingTimeStamp, reason = blockDTO.reason };
        public static Follow Converter_DTOToFollow(FollowDTO followDTO) => new Follow { Id = followDTO.Id, sender = followDTO.sender, receiver = followDTO.receiver, isCloseFriend = followDTO.isCloseFriend, expirationTimeStamp = followDTO.expirationTimeStamp, description = followDTO.description };
    }

}
