using System.Collections.Generic;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface INotaRepository
    {
        public Task<List<Nota>> GetNotasAsync(string Semestre, string Ano, string Aluno, string Curso, string Disciplina);
    }
}
