using System;
using FashionP.Models;
namespace FashionP.Data;

public class CardData
{
    public List<Card> Cards { get; set; } = new List<Card>
    {
        new Card(Guid.NewGuid(), "Trench Coat", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyktNVPmBiVTdcjtcDtEAc4ZORC5TxpY3G-g&s"),
        new Card(Guid.NewGuid(), "Turtle Neck", "https://shop.mango.com/assets/rcs/pics/static/T8/fotos/S/87010290_37.jpg?ts=1727865341112"),
        new Card(Guid.NewGuid(), "Leather Boots", "https://www.vertbaudet.co.uk/fstrz/r/s/media.vertbaudet.co.uk/Pictures/vertbaudet/497153/leather-boots-with-fur-lining-zip-for-girls.jpg?width=457"),
        new Card(Guid.NewGuid(), "Winter Coat", "https://cdn.chums.co.uk/content/assets/blog/a%20man%20walking%20down%20a%20street%20in%20a%20winter%20coat.jpg"),
        new Card(Guid.NewGuid(), "Stetson Hat", "https://stetson.com/cdn/shop/files/SWBRNM-7242-49_alt1_grande.jpg?v=1708640360"),
    };
}
