using System.ComponentModel.DataAnnotations;

namespace waGerenciamentoAcademico.Models
{
    public class Nota
    {
        [Display(Name = "ID da Matrícula")]
        public int id_matricula { get; set; }

        [Display(Name = "ID do Aluno")]
        public int id_aluno { get; set; }

        [Display(Name = "Nome do Aluno")]
        public string nome { get; set; }

        [Display(Name = "ID do Curso")]
        public int id_curso { get; set; }

        [Display(Name = "Nome do Curso")]
        public string curso { get; set; }

        [Display(Name = "ID da Disciplina")]
        public int id_disiciplina { get; set; }

        [Display(Name = "Nome da Disciplina")]
        public string disciplina { get; set; }

        [Required(ErrorMessage = "Informe o ano!")]
        [RegularExpression(@"\d{4}", ErrorMessage = "Digite somente 4 dígitos numéricos!")]
        [Display(Name = "Ano")]
        public int ano { get; set; }

        [Required(ErrorMessage = "Informe o semestre!")]
        [RegularExpression(@"[12]", ErrorMessage = "Digite 1-Primeiro Semestre e 2-Segundo Semestre")]
        [Display(Name = "Semestre")]
        public int semestre { get; set; }

        [Required(ErrorMessage = "Informar a nota!")]
        [Display(Name = "Nota")]
        public double nota { get; set; }

        [Display(Name = "Status")]
        public bool status { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }
    }
}
