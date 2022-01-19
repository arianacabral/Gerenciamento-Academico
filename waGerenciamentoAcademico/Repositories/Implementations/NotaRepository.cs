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
    public class NotaRepository : INotaRepository
    {
        private IConfiguration _configuration;

        public NotaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<List<Nota>> GetNotasAsync(string Semestre, string Ano, string Aluno, string Curso, string Disciplina)
        {
            using (MySqlConnection conn = new MySqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = $@"select matriculas.ano,
                                         matriculas.semestre,
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
                                join alunos on alunos.id = alunos_disciplinas.id_aluno
                                join cursos on cursos.id = alunos_disciplinas.id_curso
                                join disciplinas on disciplinas.id = alunos_disciplinas.id_disciplina
                                join matriculas on matriculas.id = alunos_disciplinas.id_matricula
                                where cursos.curso like '%{Curso}%' and disciplinas.disciplina like '%{Disciplina}%' and 
                                alunos.nome like '%{Aluno}%' and matriculas.ano like '%{Ano}%' and matriculas.semestre like '%{Semestre}%'";

                List<Nota> notas = (await conn.QueryAsync<Nota>(sql: query)).ToList();

                conn.Close();

                return notas;
            }
        }
    }
}
