using client.models;

namespace client.repositories
{
    internal interface IPostSavedRepository
    {
        bool addPostSavedtoDB(PostSaved postSaved);
        List<PostSaved> getAll();
        bool removePostSavedFromDB(PostSaved postSaved);
    }
}