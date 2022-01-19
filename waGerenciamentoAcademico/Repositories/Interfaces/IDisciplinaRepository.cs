using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface IDisciplinaRepository
    {
        public Task<List<Disciplina>> GetDisciplinasAsync();

        public Task<List<Curso>> GetCursosAsync();

        public Task<Disciplina> GetDisciplinaByIdAsync(int? id);

        public Task<int> SaveAsync(Disciplina novoDisciplina);

        public Task<int> UpdateDisciplinaAsync(Disciplina atualizaDisciplina);

        public Task<int> DeleteAsync(int? id);
    }
}
