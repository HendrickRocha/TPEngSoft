using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CarrosController : Controller
    {
        private readonly List<Carros> carros = new List<Carros>();

        public CarrosController()
        {
            carros.Add(new Carros()
            {
                Nome = "Fit",
                Placa = "ABC1234",
                Marca = "Honda",
                Cambio = "Automático"
            });
            carros.Add(new Carros()
            {
                Nome = "Corsa",
                Placa = "DFG1234",
                Marca = "Chevrolet",
                Cambio = "Manual"
            });
        }

        public IActionResult Index()
        {
            return View(carros);
        }
        public IActionResult Details(string id)
        {
            var carro = carros.Find(c => c.Placa == id);
            if (carro == null) return NotFound();

            return View(carro);
        }
    }
}
