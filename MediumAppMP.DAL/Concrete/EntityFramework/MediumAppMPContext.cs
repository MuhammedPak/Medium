using MediumAppMP.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediumAppMP.DAL.Concrete.EntityFramework
{
    public class MediumAppMPContext:DbContext
    {
        public MediumAppMPContext(DbContextOptions<MediumAppMPContext> options):base(options)
        {

        }
        public DbSet<Article> Article { get; set; }
        public DbSet<Tag> Tag{ get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ArticleContent> ArticleContent { get; set; }
        public DbSet<Friendship> Friendship{ get; set; }
        public DbSet<Clap> Clap { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}
