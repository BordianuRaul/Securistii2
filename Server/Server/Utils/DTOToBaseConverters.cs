using Server.DTOs;
using Server.Models;
using UBB_SE_2024_Gaborment.Server.Models;

namespace Server.Utils
{
    public class DTOToBaseConverters
    {
        public static Location Converter_DTOToLocation(LocationDTO locationDTO) => new Location { Id = locationDTO.Id, Name = locationDTO.Name, Latitude = locationDTO.Latitude, Longitude = locationDTO.Longitude };
    
        public static Post Converter_DTOToPost(PostDTO postDTO) => new Post { Post_Id = postDTO.Post_Id, Owner_User_Id = postDTO.Owner_User_Id, Description = postDTO.Description, Commented_Post_Id = postDTO.Commented_Post_Id, Original_Post_Id = postDTO.Original_Post_Id, Media_Path = postDTO.Media_Path, Post_Type = postDTO.Post_Type, Location_Id = postDTO.Location_Id, Created_Date = postDTO.Created_Date };

        public static PostArchived Converter_DTOToPostArchived(PostArchivedDTO postArchivedDTO) => new PostArchived { post_id = postArchivedDTO.post_id, archive_id = postArchivedDTO.archive_id };
        public static PostSaved Converter_DTOToPostSaved(PostSavedDTO postSavedDTO) => new PostSaved { save_id = postSavedDTO.save_id, post_id = postSavedDTO.post_id, user_id = postSavedDTO.user_id };

        public static FeedConfiguration Converter_DTOToFeedConfiguration(FeedConfigurationDTO feedConfigurationDTO) => new FeedConfiguration { ID = feedConfigurationDTO.ID, Name = feedConfigurationDTO.Name, ReactionThreshold = feedConfigurationDTO.ReactionThreshold };

        public static ControversialFeed Converter_DTOToControversialFeed(ControversialFeedDTO controversialFeedDTO) => new ControversialFeed { ID = controversialFeedDTO.ID, Name = controversialFeedDTO.Name, ReactionThreshold = controversialFeedDTO.ReactionThreshold, MinimumReactionCount = controversialFeedDTO.MinimumReactionCount, MinimumCommentCount = controversialFeedDTO.MinimumCommentCount };
        public static TrendingFeed Converter_DTOToTrendingFeed(TrendingFeedDTO trendingFeedDTO) => new TrendingFeed { ID = trendingFeedDTO.ID, Name = trendingFeedDTO.Name, ReactionThreshold = trendingFeedDTO.ReactionThreshold, LikeCount = trendingFeedDTO.LikeCount, ViewCount = trendingFeedDTO.ViewCount, CommentCount = trendingFeedDTO.CommentCount };
    }
}
