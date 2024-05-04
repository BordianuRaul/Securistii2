using client.models;

namespace client.servicesInterfaces
{
    internal interface IHashtagService
    {
        bool addHashtag(string name);
        bool addPostToHashtag(Guid postId, string hashtagName);
        List<Post> getAllPostsFromHashtag(string name);
        bool removeHashtag(string id);
        bool removePostFromHashtag(Guid postId, string hashtagName);
        Hashtag searchHashtag(string name);
    }
}