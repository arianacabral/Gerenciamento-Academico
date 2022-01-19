using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;

namespace waGerenciamentoAcademico.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        public Task<List<Aluno>> GetAlunosAsync();

        public Task<Aluno> GetAlunoByIdAsync(int? id);

        public Task<int> SaveAsync(Aluno novoAluno);

        public Task<int> UpdateAlunoAsync(Aluno atualizaAluno);

        public Task<int> DeleteAsync(int? id);

    }
}
