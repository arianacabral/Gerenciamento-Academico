using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace waGerenciamentoAcademico.Models
{
    public class Disciplina
    {
        [Display(Name = "ID da Disciplina")]
        public int id { get; set; }

        [Required(ErrorMessage ="Informar o nome da disciplina")]
        [Display(Name = "Disciplina")]
        public string? disciplina { get; set; }

        [Display(Name = "ID do Curso")]
        public int id_curso { get; set; }

        [Display(Name = "Curso")]
        public string? curso { get; set; }

        public string pagina { get; set; }
    }
}
