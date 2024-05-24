using Microsoft.EntityFrameworkCore;
using Server.Models;
using UBB_SE_2024_Gaborment.Server.Models;

namespace Server.DatabaseContext
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<PostArchived> PostArchived { get; set; } = null!;
        public DbSet<PostSaved> PostSaved { get; set; } = null!;
        public DbSet<FeedConfiguration> FeedConfigurations { get; set; } = null!;
        public DbSet<ControversialFeed> ControversialFeeds { get; set; } = null!;
        public DbSet<TrendingFeed> TrendingFeeds { get; set; } = null!;
    }
}
