using Microsoft.AspNetCore.Mvc;
using Pract1PWA.Models;

namespace Pract1PWA.Controllers
{
    public class ConversorUnidadesController : Controller
    {
        public IActionResult Index()
        {
            var model = new ConversorUnidades ();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ConversorUnidades  model)
        {
            if (ModelState.IsValid)
            {
                model.Resultado = ConvertirUnidad(model.Valor, model.UnidadOrigenId, model.UnidadDestinoId);
            }
            return View(model);
        }

        private double ConvertirUnidad(double valor, int unidadOrigenId, int unidadDestinoId)
        {
            // Factores de conversión (ejemplo: metros a otras unidades)
            Dictionary<int, double> factores = new Dictionary<int, double>
            {
                { 1, 1.0 },        // Metros (base)
                { 2, 0.001 },      // Kilómetros
                { 3, 100.0 },      // Centímetros
                { 4, 39.3701 },    // Pulgadas
                { 5, 3.28084 }     // Pies
            };

            if (factores.ContainsKey(unidadOrigenId) && factores.ContainsKey(unidadDestinoId))
            {
                // Convertir primero a metros (unidad base) y luego a la unidad destino
                double enMetros = valor / factores[unidadOrigenId];
                return enMetros * factores[unidadDestinoId];
            }

            return 0; // Si no se encuentra la conversión, devolver 0
        }
    }
}

