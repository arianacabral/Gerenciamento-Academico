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
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private IConfiguration _configuration;

        public DisciplinaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from disciplinas where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
            }
        }

        public async Task<Disciplina> GetDisciplinaByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from disciplinas where id = @id";
                string query = @"select disciplinas.id,
                                        disciplinas.disciplina,
                                        cursos.curso
                                from disciplinas
                                join cursos on cursos.id = disciplinas.id_curso
                                where disciplinas.id = @id";

                Disciplina disciplina = await conn.QueryFirstOrDefaultAsync<Disciplina>(sql: query, param: new { id });

                conn.Close();

                return disciplina;
            }
        }

        public async Task<List<Disciplina>> GetDisciplinasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from disciplinas";
                string query = @"select disciplinas.id,
                                        disciplinas.disciplina,
                                        cursos.curso
                                from disciplinas
                                join cursos on cursos.id = disciplinas.id_curso order by cursos.curso, disciplinas.disciplina";

                List<Disciplina> disciplinas = (await conn.QueryAsync<Disciplina>(sql: query)).ToList();

                conn.Close();

                return disciplinas;
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

        public async Task<int> SaveAsync(Disciplina novoDisciplina)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into disciplinas (disciplina,id_curso) values (@disciplina,@id_curso)";

                var result = await conn.ExecuteAsync(sql: query, param: novoDisciplina);

                conn.Close();

                return result;
            }
        }

        public async Task<int> UpdateDisciplinaAsync(Disciplina atualizaDisciplina)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update disciplinas set disciplina = @disciplina, id_curso = @id_curso where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaDisciplina);

                conn.Close();

                return result;
            }
        }
    }
}
