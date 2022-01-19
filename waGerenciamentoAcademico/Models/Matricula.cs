using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace waGerenciamentoAcademico.Models
{
    public class Matricula
    {
        [Display(Name = "ID da Matrícula")]
        public int id { get; set; }

        [Display(Name = "ID do Aluno")]
        public int id_aluno { get; set; }

        [Display(Name = "Nome do Aluno")]
        public string? nome { get; set; }

        [Display(Name = "ID do Curso")]
        public int id_curso { get; set; }

        [Display(Name = "Nome do Curso")]
        public string? curso { get; set; }

        [Required(ErrorMessage = "Informe o ano!")]
        [RegularExpression(@"\d{4}", ErrorMessage = "Digite somente 4 dígitos numéricos!")]
        [Display(Name = "Ano")]
        public int? ano { get; set; }

        [Required(ErrorMessage = "Informe o semestre!")]
        [RegularExpression(@"[12]", ErrorMessage = "Digite 1-Primeiro Semestre e 2-Segundo Semestre")]
        [Display(Name = "Semestre")]
        public int? semestre { get; set; }

        [Display(Name ="Matrícula")]
        public string? descricao { get; set; }
    }
}
