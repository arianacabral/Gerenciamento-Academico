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
    public class AlunoDisciplinaRepository : IAlunoDisciplinaRepository
    {
        private IConfiguration _configuration;

        public AlunoDisciplinaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> DeleteAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"delete from alunos_disciplinas where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: new { id });

                conn.Close();

                return result;
            }
        }

        public async Task<AlunoDisciplina> GetAlunoPorDisciplinaByIdAsync(int? id)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from alunos_disciplinas where id = @id";
                string query = @"select alunos_disciplinas.id,
                                        alunos_disciplinas.id_matricula,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        alunos_disciplinas.id_disciplina,
                                        disciplinas.disciplina,
                                        alunos_disciplinas.nota,
                                        alunos_disciplinas.status
                                        from alunos_disciplinas
                                        join matriculas on matriculas.id = alunos_disciplinas.id_matricula
                                        join alunos on alunos.id = alunos_disciplinas.id_aluno
                                        join cursos on cursos.id = alunos_disciplinas.id_curso
                                        join disciplinas on disciplinas.id = alunos_disciplinas.id_disciplina
                                        where alunos_disciplinas.id = @id";

                AlunoDisciplina aluno_disciplina = await conn.QueryFirstOrDefaultAsync<AlunoDisciplina>(sql: query, param: new { id });

                conn.Close();

                return aluno_disciplina;
            }
        }

        public async Task<Matricula> GetMatriculaByAsync(int? idAluno, int? idCurso, int? ano, int? semestre)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select *
                                        from matriculas
                                        where id_aluno = @idAluno and
                                        id_curso = @idCurso and
                                        ano = @ano and
                                        semestre = @semestre";

                Matricula matricula = await conn.QueryFirstOrDefaultAsync<Matricula>(sql: query, param: new { idAluno, idCurso, ano, semestre });

                conn.Close();

                return matricula;
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

        public async Task<List<AlunoDisciplina>> GetAlunosPorDisciplinasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from alunos_disciplinas";

                string query = @"select alunos_disciplinas.id,
                                        alunos_disciplinas.id_matricula,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        alunos_disciplinas.id_disciplina,
                                        disciplinas.disciplina,
                                        alunos_disciplinas.nota,
                                        alunos_disciplinas.status
                                        from alunos_disciplinas
                                        join matriculas on matriculas.id = alunos_disciplinas.id_matricula
                                        join alunos on alunos.id = alunos_disciplinas.id_aluno
                                        join cursos on cursos.id = alunos_disciplinas.id_curso
                                        join disciplinas on disciplinas.id = alunos_disciplinas.id_disciplina
                                        order by cursos.curso, disciplinas.disciplina";

                List<AlunoDisciplina> alunos_disciplinas = (await conn.QueryAsync<AlunoDisciplina>(sql: query)).ToList();

                conn.Close();

                return alunos_disciplinas;
            }
        }

        public async Task<List<AlunoDisciplina>> GetAlunosPorDisciplinasByCursoAsync(string? Curso)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //string query = @"select * from alunos_disciplinas";

                string query = $@"select alunos_disciplinas.id,
                                        alunos_disciplinas.id_matricula,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        alunos_disciplinas.id_disciplina,
                                        disciplinas.disciplina,
                                        alunos_disciplinas.nota,
                                        alunos_disciplinas.status
                                        from alunos_disciplinas
                                        join matriculas on matriculas.id = alunos_disciplinas.id_matricula
                                        join alunos on alunos.id = alunos_disciplinas.id_aluno
                                        join cursos on cursos.id = alunos_disciplinas.id_curso
                                        join disciplinas on disciplinas.id = alunos_disciplinas.id_disciplina 
                                        where cursos.curso like '%{Curso}%'";

                List<AlunoDisciplina> alunos_disciplinas = (await conn.QueryAsync<AlunoDisciplina>(sql: query)).ToList();

                conn.Close();

                return alunos_disciplinas;
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

        public async Task<List<Disciplina>> GetDisciplinasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"select * from disciplinas";

                List<Disciplina> disciplinas = (await conn.QueryAsync<Disciplina>(sql: query)).ToList();

                conn.Close();

                return disciplinas;
            }
        }

        public async Task<List<Matricula>> GetMatriculasAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                /* string query = @"select matriculas.id,
                                        matriculas.id_aluno,
                                        alunos.nome,
                                        matriculas.id_curso,
                                        cursos.curso,
                                        matriculas.ano,
                                        matriculas.semestre
                                        from matriculas
                                        join alunos on alunos.id = matriculas.id_aluno
                                        join cursos on cursos.id = matriculas.id_curso";*/

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

        public async Task<int> SaveAsync(AlunoDisciplina novoAlunoDisciplina)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"insert into alunos_disciplinas (id_matricula,id_aluno,id_curso,id_disciplina,nota,status) values (@id_matricula,@id_aluno,@id_curso,@id_disciplina,@nota,@status)";

                var result = await conn.ExecuteAsync(sql: query, param: novoAlunoDisciplina);

                return result;
            }
        }

        public async Task<int> UpdateAlunoDisciplinaAsync(AlunoDisciplina atualizaAlunoDisciplina)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = @"update alunos_disciplinas set id_matricula=@id_matricula,
                                                       id_aluno=@id_aluno,
                                                       id_curso=@id_curso,
                                                       id_disciplina=@id_disciplina,
                                                       nota=@nota,
                                                       status=@status where id = @id";

                var result = await conn.ExecuteAsync(sql: query, param: atualizaAlunoDisciplina);

                conn.Close();

                return result;
            }
        }
    }
}
