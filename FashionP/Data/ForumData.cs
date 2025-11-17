using System;
using FashionP.Models;
namespace FashionP.Data;

public class ForumData
{
    public List<Forum> Forums { get; } = new()
    {
        new Forum(Guid.NewGuid(), "Summer Clothes", "Any recommendations for summer clothes? My wardrobe is filled with winter clothes", DateTime.Now.ToString("MM/dd/yyyy")),
        new Forum(Guid.NewGuid(), "Statement", "I want to make a statement with my clothing at my next meeting with my friend", DateTime.Now.ToString("MM/dd/yyyy")),
        new Forum(Guid.NewGuid(), "Aura", "Final Boss clothes? There's an upcoming cosplay event and I'd want to look like a final boss lol", DateTime.Now.ToString("MM/dd/yyyy")),
        new Forum(Guid.NewGuid(), "Frieren", "How do I tie my scarf like Frieren? The show was so good that I want to copy her style", DateTime.Now.ToString("MM/dd/yyyy")),
    };
}
