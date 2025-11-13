using System;
using FashionP.Models;
namespace FashionP.Data;

public class CardData
{
    public List<Card> Cards { get; set; } = new List<Card>
    {
        new Card(Guid.NewGuid(), "Summer Dress", "https://example.com/images/summer_dress.jpg"),
        new Card(Guid.NewGuid(), "Casual Outfit", "https://example.com/images/casual_outfit.jpg"),
        new Card(Guid.NewGuid(), "Formal Wear", "https://example.com/images/formal_wear.jpg"),
        new Card(Guid.NewGuid(), "Winter Coat", "https://example.com/images/winter_coat.jpg"),
        new Card(Guid.NewGuid(), "Sporty Look", "https://example.com/images/sporty_look.jpg"),
    };
}
