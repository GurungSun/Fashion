using System;
using FashionP.Models;
namespace FashionP.Data;

public class ForumData
{
    public List<Forum> Forums { get; } = new()
    {
        new Forum(Guid.NewGuid(), "Summer Fashion Trends", "Explore the latest trends in summer fashion for 2024!", DateTime.Now.ToString("MMMM dd, yyyy")),
        new Forum(Guid.NewGuid(), "Sustainable Fashion", "Discuss the importance of sustainability in the fashion industry.", DateTime.Now.ToString("MMMM dd, yyyy")),
        new Forum(Guid.NewGuid(), "Street Style Inspiration", "Share your favorite street style looks and inspirations.", DateTime.Now.ToString("MMMM dd, yyyy")),
    };
}
