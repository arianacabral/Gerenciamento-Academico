using System.Collections.Generic;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface IDisciplinaCursoRepository
    {
        public Task<List<Curso>> GetCursosAsync();

        public Task<List<Disciplina>> GetDisciplinasAsync();

        public Task<List<DisciplinaCurso>> GetDisciplinasPorCursosAsync();

        public Task<List<DisciplinaCurso>> GetDisciplinasPorCursosByCursoAsync(string Curso);

        public Task<DisciplinaCurso> GetDisciplinaPorCursoByIdAsync(int? id);

        public Task<int> SaveAsync(DisciplinaCurso novaDisciplinaCurso);

        public Task<int> UpdateDisciplinaCursoAsync(DisciplinaCurso atualizaDisciplinaCurso);

        public Task<int> DeleteAsync(int? id);
    }
}
