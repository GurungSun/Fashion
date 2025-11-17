using System;
using FashionP.Models;
using FashionP.Data;
namespace FashionP.Services;

public class CardService
{
    List<Card> cards = new();

    public CardService(CardData data)
    {
        cards = data.Cards;
    }

    public List<Card> GetCards()
    {
        return cards;
    }
}
