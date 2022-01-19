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
    public class CursoRepository : ICursoRepository
    {
        private IConfiguration _configuration;

        public CursoRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from cursos where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
            }
        }

        public async Task<Curso> GetCursoByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from cursos where id = @id";

                Curso curso = await conn.QueryFirstOrDefaultAsync<Curso>(sql: query, param: new { id });

                conn.Close();

                return curso;
            }
        }

        public async Task<List<Curso>> GetCursosAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from cursos order by curso";

                List<Curso> cursos = (await conn.QueryAsync<Curso>(sql: query)).ToList();

                conn.Close();

                return cursos;
            }
        }

        public async Task<List<Curso>> GetCursosByLimitAsync(int? pagAtual, int? qtdItens)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = $@"select * from cursos order by curso limit {(pagAtual - 1) * qtdItens},{qtdItens}";

                List<Curso> cursos = (await conn.QueryAsync<Curso>(sql: query)).ToList();

                conn.Close();

                return cursos;
            }
        }

        public async Task<int> SaveAsync(Curso novoCurso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into cursos (curso) values (@curso)";

                var result = await conn.ExecuteAsync(sql: query, param: novoCurso);

                conn.Close();

                return result;
            }
        }

        public async Task<int> UpdateCursoAsync(Curso atualizaCurso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update cursos set id = @id, curso = @curso where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaCurso);

                conn.Close();

                return result;
            }
        }
    }
}
