using System;
using System.Collections.Generic;
using FashionP.Models;
using FashionP.Data;

namespace FashionP.Services;

public class FService
{
    List<Forum> forums = new();

    public FService(ForumData data)
    {
        forums = data.Forums;
    }

    public List<Forum> GetForums()
    {
        return forums;
    }
}
