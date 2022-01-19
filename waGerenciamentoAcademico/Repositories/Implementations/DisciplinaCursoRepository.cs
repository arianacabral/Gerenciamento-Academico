using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;
using waGerenciamentoAcademico.Repositories.Interfaces;

namespace waGerenciamentoAcademico.Repositories.Implementations
{
    public class DisciplinaCursoRepository : IDisciplinaCursoRepository
    {
        private IConfiguration _configuration;

        public DisciplinaCursoRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from disciplinas_cursos where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
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

        public async Task<DisciplinaCurso> GetDisciplinaPorCursoByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select disciplinas_cursos.id,
                                        disciplinas_cursos.id_curso,
                                        cursos.curso,
                                        disciplinas_cursos.id_disciplina,
                                        disciplinas.disciplina,
                                        disciplinas_cursos.data_desativacao
                                        from disciplinas_cursos
                                        join cursos on cursos.id = disciplinas_cursos.id_curso
                                        join disciplinas on disciplinas.id = disciplinas_cursos.id_disciplina
                                        where disciplinas_cursos.id = @id";

                DisciplinaCurso disciplina_curso = await conn.QueryFirstOrDefaultAsync<DisciplinaCurso>(sql: query, param: new { id });

                conn.Close();

                return disciplina_curso;
            }
        }

        public async Task<List<Disciplina>> GetDisciplinasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from disciplinas order by disciplina";

                List<Disciplina> disciplinas = (await conn.QueryAsync<Disciplina>(sql: query)).ToList();

                conn.Close();

                return disciplinas;
            }
        }

        public async Task<List<DisciplinaCurso>> GetDisciplinasPorCursosAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select disciplinas_cursos.id,
                                        disciplinas_cursos.id_curso,
                                        cursos.curso,
                                        disciplinas_cursos.id_disciplina,
                                        disciplinas.disciplina,
                                        disciplinas_cursos.data_desativacao
                                        from disciplinas_cursos
                                        join cursos on cursos.id = disciplinas_cursos.id_curso
                                        join disciplinas on disciplinas.id = disciplinas_cursos.id_disciplina
                                        order by cursos.curso, disciplinas.disciplina";

                List<DisciplinaCurso> disciplina_curso = (await conn.QueryAsync<DisciplinaCurso>(sql: query)).ToList();

                conn.Close();

                return disciplina_curso;
            }
        }

        public async Task<List<DisciplinaCurso>> GetDisciplinasPorCursosByCursoAsync(string Curso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = $@"select disciplinas_cursos.id,
                                        disciplinas_cursos.id_curso,
                                        cursos.curso,
                                        disciplinas_cursos.id_disciplina,
                                        disciplinas.disciplina,
                                        disciplinas_cursos.data_desativacao
                                        from disciplinas_cursos
                                        join cursos on cursos.id = disciplinas_cursos.id_curso
                                        join disciplinas on disciplinas.id = disciplinas_cursos.id_disciplina
                                        where cursos.curso like '%{Curso}%'";

                List<DisciplinaCurso> disciplinas_cursos = (await conn.QueryAsync<DisciplinaCurso>(sql: query)).ToList();

                conn.Close();

                return disciplinas_cursos;
            }
        }

        public async Task<int> SaveAsync(DisciplinaCurso novaDisciplinaCurso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into disciplinas_cursos (id_curso,id_disciplina,data_desativacao) values (@id_curso,@id_disciplina,@data_desativacao)";

                var result = await conn.ExecuteAsync(sql: query, param: novaDisciplinaCurso);

                conn.Close();

                return result;
            }
        }

        public async Task<int> UpdateDisciplinaCursoAsync(DisciplinaCurso atualizaDisciplinaCurso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update disciplinas_cursos set id_curso=@id_curso,
                                                       id_disciplina=@id_disciplina,
                                                       data_desativacao=@data_desativacao
                                                       where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaDisciplinaCurso);

                conn.Close();

                return result;
            }
        }
    }
}
