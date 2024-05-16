using client.models;

namespace client.repositories
{
    internal interface IPostsRepository
    {
        bool addMentionToPost(Guid postID, Guid userID);
        bool addPostToDB(Post post);
        bool addReactionToPost(Guid postID, Guid userID, int reactionType);
        List<Post> getAllPosts();
        List<Post> getAllPostsFromLocation(string locationID);
        Post getPostById(Guid postId);
        int getPostLikeCount(Guid postId);
        bool removePostFromDB(Guid postID);
        bool removeReactionToPost(Guid postID, Guid userID);
        bool updatePostDescription(Guid postID, string newDescription);
        bool updatePostLocation(Guid postID, string newLocationID);
    }
}