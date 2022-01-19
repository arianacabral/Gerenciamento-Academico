using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface IMatriculaRepository
    {
        public Task<List<Aluno>> GetAlunosAsync();

        public Task<List<Curso>> GetCursosAsync();

        public Task<List<Matricula>> GetMatriculasAsync();

        public Task<Matricula> GetMatriculaByIdAsync(int? id);

        public Task<int> SaveAsync(Matricula novoMatricula);

        public Task<int> UpdateMatriculaAsync(Matricula atualizaMatricula);

        public Task<int> DeleteAsync(int? id);
    }
}
