using System;

namespace FashionP.Models;

public class Culture
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public Culture(Guid id, string name, string description, string imageUrl)
    {
        Id = id;
        Name = name;
        Description = description;
        ImageUrl = imageUrl;
    }
}
