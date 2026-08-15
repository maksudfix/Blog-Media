using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlogMedia.Models;

namespace BlogMedia.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology"},
                new Category { Id = 2, Name = "Heath" },
                new Category { Id = 3, Name = "LifeStyle" }
            );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "The Future of AI: How Artificial Intelligence is Changing the World",
                    Content = "Artificial intelligence (AI) is rapidly transforming the way we live and work. From self-driving cars to virtual assistants, AI is becoming an integral part of our daily lives. In this article, we will explore the future of AI and how it is changing the world.",
                    Author = "Maksud Mubin",
                    PublishDate = new DateTime(2026,7,2),
                    CategoryId = 1,
                    FeatureImagePath = "tech_image.jpg",
                },
                 new Post
                 {
                     Id = 2,
                     Title = "How To Eat Healthy",
                     Content = "A healthy lifestyle includes eating balanced meals, exercising regularly, and maintaining proper hydration.",
                     Author = "Afsin Binte",
                     PublishDate = new DateTime(2026, 7, 2),
                     CategoryId = 2,
                     FeatureImagePath = "health_image.jpg",
                 },
                  new Post
                  {
                      Id = 3,
                      Title = "Exploring Japanese Cuisine",
                      Content = "Japanese cuisine is famous for its fresh ingredients, unique flavors, and artistic presentation.",
                      Author = "Nahar",
                      PublishDate = new DateTime(2026, 7, 2),
                      CategoryId = 3,
                      FeatureImagePath = "lifestyle_image.jpg",
                  }
           );
        }
    }
}
