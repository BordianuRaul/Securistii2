using client.models;

namespace client.servicesInterfaces
{
    internal interface IPostSavedService
    {
        bool addPostSaved(PostSaved postSaved);
        List<PostSaved> getPostSavedList();
        bool removePostSaved(PostSaved postSaved);
    }
}