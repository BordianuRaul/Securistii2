using client.models;

namespace client.servicesInterfaces
{
    internal interface IPostsService
    {
        bool addMentionToPost(Guid postID, Guid userID);
        bool addPost(Guid owner_user_id, string? description, List<Guid> mentionedUsers, Guid commented_post_id, Guid original_post_id, string? path, int post_type, string? location_id);
        bool addReactionToPost(Guid postID, Guid userID, int reactionType);
        List<Post> getAllPosts();
        List<Post> getAllPostsFromLocation(string location_id);
        Post getPostById(Guid postId);
        int getPostLikeCount(Guid postID);
        bool removePost(Guid post_id);
        bool removeReactionToPost(Guid postID, Guid userID);
        bool updateDescription(Guid post_id, string newDescription);
        bool updateLocation(Guid post_id, string newLocationID);
    }
}