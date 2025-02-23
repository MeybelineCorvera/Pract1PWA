using System.ComponentModel.DataAnnotations;

namespace Pract1PWA.Models
{
    public class ConversorUnidades
    {
        [Required]
        [Display(Name = "Valor a Convertir")]
        public double Valor { get; set; } = 0;

        [Required]
        [Display(Name = "Unidad de Origen")]
        public int UnidadOrigenId { get; set; }

        [Required]
        [Display(Name = "Unidad de Destino")]
        public int UnidadDestinoId { get; set; }

        [Display(Name = "Resultado")]
        public double Resultado { get; set; }

        public List<TipoUnidad> ListaUnidades { get; set; }

        public ConversorUnidades()
        {
            ListaUnidades = new List<TipoUnidad>
            {
                new TipoUnidad { Id = 1, Nombre = "Metros" },
                new TipoUnidad { Id = 2, Nombre = "Kilómetros" },
                new TipoUnidad { Id = 3, Nombre = "Centímetros" },
                new TipoUnidad { Id = 4, Nombre = "Pulgadas" },
                new TipoUnidad { Id = 5, Nombre = "Pies" }
            };
        }
    }
}
