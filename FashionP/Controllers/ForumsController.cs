using System;
using System.Collections.Generic;
using FashionP.Models;
using FashionP.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashionP.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ForumsController : ControllerBase
{
    private readonly FService _fservice;

    public ForumsController(FService fservice)
    {
        _fservice = fservice;
    }

    [HttpGet]
    public ActionResult<List<Forum>> GetForums()
    {
        var forums = _fservice.GetForums();
        return Ok(forums);
    }
}
