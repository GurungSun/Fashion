using System;
using FashionP.Models;
using FashionP.Data;

namespace FashionP.Services;

public class CulService
{
    List<Culture> cultures = new();

    public CulService(CultureData data)
    {
        cultures = data.Cultures;
    }

    public List<Culture> GetCultures()
    {
        return cultures;
    }
}
