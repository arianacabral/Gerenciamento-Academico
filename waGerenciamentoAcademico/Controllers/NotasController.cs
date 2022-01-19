using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Repositories.Interfaces;

namespace waGerenciamentoAcademico.Controllers
{
    public class NotasController:Controller
    {
        private readonly INotaRepository _notaRepository;

        public NotasController(INotaRepository notaRepository)
        {
            _notaRepository = notaRepository;
        }

        // GET: NotasController
        public async Task<IActionResult> Relatorio(string Semestre, string Ano, string Aluno, string Curso, string Disciplina)
        {
            return View(await _notaRepository.GetNotasAsync(Semestre, Ano, Aluno, Curso, Disciplina));
        }
    }
}
