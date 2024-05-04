using client.models;

namespace client.repositories
{
    internal interface IPostArchivedRepository
    {
        bool addPostArchivedToDB(PostArchived postArchived);
        List<PostArchived> getAll();
        bool removePostArchivedFromDB(PostArchived postArchived);
    }
}