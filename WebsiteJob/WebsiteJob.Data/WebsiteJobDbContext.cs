using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data
{
    public partial class WebsiteJobDbContext : DbContext
    {
        public WebsiteJobDbContext()
            : base("WebsiteJobConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PostCategory> PostCategories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SupportOnline> SupportOnlines { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Employer>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Footer>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<JobCategory>()
                .Property(e => e.Alas)
                .IsUnicode(false);

            modelBuilder.Entity<JobCategory>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<JobCategory>()
                .Property(e => e.Updatedby)
                .IsUnicode(false);

            modelBuilder.Entity<JobCategory>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.JobCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Alas)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Updatedby)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Jobs)
                .Map(m => m.ToTable("JobTags").MapLeftKey("JobID").MapRightKey("TagID"));

            modelBuilder.Entity<Menu>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.MenuGroup)
                .HasForeignKey(e => e.GroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Alas)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Updatedby)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .HasMany(e => e.Posts)
                .WithRequired(e => e.PostCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Alas)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Createdby)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Updatedby)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("PostTags").MapLeftKey("PostID").MapRightKey("TagID"));

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<VisitorStatistic>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);



        }
    }
}
