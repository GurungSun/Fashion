using System;
using FashionP.Models;
using FashionP.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashionP.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CardsController
{
    private readonly CardService _cardService;

    public CardsController(CardService cardService)
    {
        _cardService = cardService;
    }

    public List<Card> GetCards()
    {
        var cards = _cardService.GetCards();
        return cards;
    }
}
