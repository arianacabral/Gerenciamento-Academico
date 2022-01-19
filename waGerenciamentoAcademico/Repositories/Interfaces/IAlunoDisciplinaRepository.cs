using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface IAlunoDisciplinaRepository
    {
        public Task<List<Aluno>> GetAlunosAsync();

        public Task<List<Curso>> GetCursosAsync();

        public Task<List<Disciplina>> GetDisciplinasAsync();

        public Task<List<Matricula>> GetMatriculasAsync();

        public Task<List<AlunoDisciplina>> GetAlunosPorDisciplinasAsync();

        public Task<List<AlunoDisciplina>> GetAlunosPorDisciplinasByCursoAsync(string? Curso);

        public Task<AlunoDisciplina> GetAlunoPorDisciplinaByIdAsync(int? id);

        public Task<Matricula> GetMatriculaByAsync(int? idAluno, int? idCurso, int? ano, int? semestre);

        public Task<int> SaveAsync(AlunoDisciplina novoAlunoDisciplina);

        public Task<int> UpdateAlunoDisciplinaAsync(AlunoDisciplina atualizaAlunoDisciplina);

        public Task<int> DeleteAsync(int? id);
    }
}
