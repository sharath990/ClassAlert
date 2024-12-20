using Microsoft.EntityFrameworkCore;
using Webservices.Models;

namespace Webservices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Stream> Streams { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<MessageHistory> MessageHistories { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<MessageTemplate> MessageTemplates { get; set; }

    }
}
