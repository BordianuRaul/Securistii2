using client.models;

namespace client.repositories
{
    internal interface IHashtagRepository
    {
        bool addHashtag(Hashtag hashtag);
        bool addHashtagPost(string postId, string hashtagId);
        List<Post> getAllPosts(string hashtagId);
        bool removeHashtag(string id);
        bool removePostFromHashtag(string postId, string hashtagId);
        Hashtag searchHashtag(string name);
        bool searchPostHashtagPair(string postId, string hashtagId);
    }
}