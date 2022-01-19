using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace waGerenciamentoAcademico.Models
{
    public class AlunoDisciplina
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Matrícula")]
        public int? id_matricula { get; set; }

        [RegularExpression(@"\d{4}", ErrorMessage = "Digite somente 4 dígitos numéricos!")]
        [Display(Name = "Ano")]
        public int? ano { get; set; }

        [RegularExpression(@"[12]", ErrorMessage = "Digite 1-Primeiro Semestre e 2-Segundo Semestre")]
        [Display(Name = "Semestre")]
        public int? semestre { get; set; }

        [Display(Name = "ID do Aluno")]
        public int id_aluno { get; set; }

        [Display(Name = "Aluno")]
        public string? nome { get; set; }

        [Display(Name = "ID do Curso")]
        public int id_curso { get; set; }

        [Display(Name = "Curso")]
        public string? curso { get; set; }

        [Display(Name = "ID da Disciplina")]
        public int id_disciplina { get; set; }

        [Display(Name = "Disciplina")]
        public string? disciplina { get; set; }

        [Required(ErrorMessage = "Informar a nota!")]
        [Range(0,100)]
        [Display(Name = "Nota")]
        public double nota { get; set; }

        [Display(Name = "Status")]
        public bool status { get; set; }

        [Display(Name = "Descrição")]
        public string? descricao { get; set; }

        public List<Matricula> listaMatriculas { get; set; }

    }
}
