using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDOTNET.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCDOTNET.Controllers;

public class ConcessionariaController
    {
        private List<Carro> carros = new List<Carro>();

        public void AdicionarCarro(int id, string marca, string modelo, decimal preco)
        {
            Carro carro = new Carro { Id = id, Marca = marca, Modelo = modelo, Preco = preco };
            carros.Add(carro);
        }

        public List<Carro> ListarCarros()
        {
            return carros;
        }
    }

class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public ContentVerify Index()
    {
        return View();
    }

    public ContentVerify Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public ContentVerify Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
