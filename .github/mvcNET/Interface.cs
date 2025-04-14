using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
public class interface Interface
{
    class interface{
        @model List<ConcessionariaApp.Models.Carro>
        @ViewData["Title"] = "Carro List";
        <h1>Carro List</h1>

    }

    public static void Main(string[] args)
    {
        return View();
        return View("Index");
        return View("Index", new List<ConcessionariaApp.Models.Carro>());
    }
}
