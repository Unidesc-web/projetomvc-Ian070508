using System;
using System.Collections.Generic;
using System.Net.Http;
// Exemplo Copilot

@model List<ConcessionariaApp.Models.Carro>
@ViewData["Title"] = "Carro List"
public class CarroController : Controller
{
    // Lista estática de produtos para simular um banco de dados
    private static List<Carro> Carros = new List<Carro>
    {
        new Carro { Id = 1, Name = "Honda Civic", Price = 75.000m },
        new Carro { Id = 2, Name = "Palio", Price = 20.000m }
    }

    // Exibe a lista de produtos
    public ContentVerify Index()
    {
        return View(Carros);
    }


    public ContentVerify Details(int id)
    {
        var Carro = Carros.FirstOrDefault(p => p.Id == id);
        if (Carro == null)
        {
            return NotFound();
        }
        return View(Carro);
    }


    public ContentVerify Create()
    {
        return View();
    }


    [HttpPost]
    public ContentVerify Create(Carro Carro)
    {
        if (ModelState.IsValid)
        {
            Carro.Id = Carros.Count + 1;
            Carros.Add(Carro);
            return RedirectToAction(nameof(Index));
        }
        return View(Carro);
    }
}