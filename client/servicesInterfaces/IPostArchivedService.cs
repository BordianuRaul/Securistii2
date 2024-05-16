using client.models;

namespace client.servicesInterfaces
{
    internal interface IPostArchivedService
    {
        bool addPostArchived(PostArchived postArchived);
        List<PostArchived> getPostArchivedList();
        bool removePostArchived(PostArchived postArchived);
    }
}