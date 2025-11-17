using System;
using FashionP.Services;
using FashionP.Models;
using Microsoft.AspNetCore.Mvc;


namespace FashionP.Controllers;

public class CultureController
{
    private readonly CulService _culService;

    public CultureController(CulService culService)
    {
        _culService = culService;
    }

    public List<Culture> GetCultures()
    {
        var cultures = _culService.GetCultures();
        return cultures;
    }
}
