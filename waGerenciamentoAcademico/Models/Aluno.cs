using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace waGerenciamentoAcademico.Models
{
    public class Aluno
    {
        [Display(Name = "ID Aluno")]
        public int id { get; set; }

        [Required(ErrorMessage = "Informar o nome do aluno!")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Foto do Aluno")]
        public IFormFile imagem { get; set; }

        [Display(Name ="Nome do Arquivo")]
        public string nomeArquivo { get; set; }
        
        [Display(Name = "Caminho do Arquivo")]
        public string caminhoArquivo { get; set; }

        [Display(Name = "Comprovante de Matrícula")]
        public IFormFile comprovante { get; set; }

        public string caminhoArquivoComprovante { get; set; }

        public string nomeArquivoComprovante { get; set; }


    }
}
