using mentorapphomedynamic.Models;
using Microsoft.EntityFrameworkCore;

namespace mentorapphomedynamic.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<WhyUs> WhyUss { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

    }
}
