using client.models;

namespace client.repositories
{
    internal interface IPostReportedRepository
    {
        bool addReportedPostToDB(PostReported postReported);
        List<PostReported> getAll();
        bool removeReportedPostFromDB(PostReported postReported);
    }
}