using client.models;

namespace client.servicesInterfaces
{
    internal interface IPostReportedService
    {
        bool addPostReported(PostReported postReported);
        List<PostReported> getPostReportedList();
        bool removePostReported(PostReported postReported);
    }
}