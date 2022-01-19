using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace waGerenciamentoAcademico.Models
{
    public class Curso
    {
        [Display(Name = "ID Curso")]
        public int id { get; set; }

        [Required(ErrorMessage = "Informar o nome do curso!")]
        [Display(Name = "Curso")]
        public string curso { get; set; }

        public string pagina { get; set; }
    }
}
