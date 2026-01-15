using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Model
{
    public class GastoDT
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fecha obligatoria.")]
        public DateOnly Fecha { get; set; }

        [Required(ErrorMessage = "Descripcion obligatoria.")]
        public string Descripcion { get; set; }

        [Required]
        [Range (0.01, 999999,ErrorMessage = "El monto debe ser mayor que 0.01" )]
        public decimal Monto  {get; set;}

        [Required(ErrorMessage = "Categoria Obligatoria")]
        public string Categoria {get; set;}
    }
}
