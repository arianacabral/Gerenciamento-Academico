using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;
using waGerenciamentoAcademico.Repositories.Interfaces;

namespace waGerenciamentoAcademico.Repositories.Implementations
{
    public class AlunoRepository : IAlunoRepository
    {
        private IConfiguration _configuration;

        public AlunoRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from alunos where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
            }
        }

        public async Task<Aluno> GetAlunoByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from alunos where id = @id order by nome";

                Aluno aluno = await conn.QueryFirstOrDefaultAsync<Aluno>(sql: query, param: new { id });

                conn.Close();

                return aluno;
            }
        }

        public async Task<List<Aluno>> GetAlunosAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from alunos order by nome";

                List<Aluno> alunos = (await conn.QueryAsync<Aluno>(sql: query)).ToList();

                conn.Close();

                return alunos;
            }
        }

        public async Task<int> SaveAsync(Aluno novoAluno)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into alunos (nome,caminhoArquivo,
                                                     nomeArquivo,caminhoArquivoComprovante,
                                                     nomeArquivoComprovante) values (@nome,
                                                                                     @caminhoArquivo,
                                                                                     @nomeArquivo,
                                                                                     @caminhoArquivoComprovante,
                                                                                     @nomeArquivoComprovante)";

                var result = await conn.ExecuteAsync(sql: query, param: novoAluno);

                conn.Close();

                return result;
            }
        }

        public async Task<int> UpdateAlunoAsync(Aluno atualizaAluno)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update alunos set nome=@nome, caminhoArquivo=@caminhoArquivo, nomeArquivo=@nomeArquivo,
                                                   caminhoArquivoComprovante = @caminhoArquivoComprovante,
                                                   nomeArquivoComprovante =@nomeArquivoComprovante where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaAluno);

                conn.Close();

                return result;
            }
        }
    }
}
