using System;

namespace FashionP.Models;

public class Card
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public Card(Guid id, string title, string imageUrl)
    {
        Id = id;
        Title = title;
        ImageUrl = imageUrl;
    }
}
