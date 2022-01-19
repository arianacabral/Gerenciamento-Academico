using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace waGerenciamentoAcademico.Models
{
    public class DisciplinaCurso
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "ID do Curso")]
        public int id_curso { get; set; }

        [Display(Name = "Curso")]
        public string curso { get; set; }

        [Display(Name = "ID da Disciplina")]
        public int id_disciplina { get; set; }

        [Display(Name = "Disciplina")]
        public string disciplina { get; set; }

        [Display(Name = "Data de Desativação")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data_desativacao { get; set; }

        public List<Curso> listaCursos { get; set; }

    }
}
