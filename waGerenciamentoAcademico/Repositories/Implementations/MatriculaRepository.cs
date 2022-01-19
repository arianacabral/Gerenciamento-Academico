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
    public class MatriculaRepository : IMatriculaRepository
    {
        private IConfiguration _configuration;

        public MatriculaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from matriculas where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
            }
        }

        public async Task<List<Aluno>> GetAlunosAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from alunos";

                List<Aluno> alunos = (await conn.QueryAsync<Aluno>(sql: query)).ToList();

                conn.Close();

                return alunos;
            }
        }

        public async Task<List<Curso>> GetCursosAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from cursos";

                List<Curso> cursos = (await conn.QueryAsync<Curso>(sql: query)).ToList();

                conn.Close();

                return cursos;
            }
        }

        public async Task<Matricula> GetMatriculaByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from matriculas where id = @id";
                string query = @"select matriculas.id,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        matriculas.ano,
                                        matriculas.semestre
                                        from matriculas
                                        join alunos on alunos.id = matriculas.id_aluno
                                        join cursos on cursos.id = matriculas.id_curso
                                        where matriculas.id = @id";

                Matricula matricula = await conn.QueryFirstOrDefaultAsync<Matricula>(sql: query, param: new { id });

                conn.Close();

                return matricula;
            }
        }

        public async Task<List<Matricula>> GetMatriculasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from matriculas";

                string query = @"select matriculas.id,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        matriculas.ano,
                                        matriculas.semestre
                                        from matriculas
                                        join alunos on alunos.id = matriculas.id_aluno
                                        join cursos on cursos.id = matriculas.id_curso";

                List<Matricula> matriculas = (await conn.QueryAsync<Matricula>(sql: query)).ToList();

                conn.Close();

                return matriculas;
            }
        }

        public async Task<int> SaveAsync(Matricula novoMatricula)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into matriculas (id_aluno,id_curso,ano,semestre) values (@id_aluno,@id_curso,@ano,@semestre)";

                var result = await conn.ExecuteAsync(sql: query, param: novoMatricula);

                conn.Close();

                return result;
            } 
        }

        public async Task<int> UpdateMatriculaAsync(Matricula atualizaMatricula)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update matriculas set id_aluno=@id_aluno,id_curso=@id_curso,ano=@ano,semestre=@semestre where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaMatricula);

                conn.Close();

                return result;
            }
        }
    }
}
