using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;
using waGerenciamentoAcademico.Repositories.Interfaces;

namespace waGerenciamentoAcademico.Controllers
{
    public class AlunosPorDisciplinasController:Controller
    {
        private readonly IAlunoDisciplinaRepository _alunoDisciplinaRepository;

        public AlunosPorDisciplinasController(IAlunoDisciplinaRepository alunoDisciplinaRepository)
        {
            _alunoDisciplinaRepository = alunoDisciplinaRepository;
        }

        // GET: AlunosPorDisciplinasController
        public async Task<IActionResult> Relatorio(string Curso)
        {
            var alunos_disciplinas = await _alunoDisciplinaRepository.GetAlunosPorDisciplinasByCursoAsync(Curso);

            return View(alunos_disciplinas);
        }

        // GET: AlunosPorDisciplinasController
        public async Task<IActionResult> Index()
        {
            return View(await _alunoDisciplinaRepository.GetAlunosPorDisciplinasAsync());
        }

        // GET: AlunosPorDisciplinasController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno_disciplina = await _alunoDisciplinaRepository
                .GetAlunoPorDisciplinaByIdAsync(id);
            if (aluno_disciplina == null)
            {
                return NotFound();
            }

            return View(aluno_disciplina);
        }

        // GET: AlunosPorDisciplinasController/Create
        public ActionResult Create()
        {
            AlunoDisciplina alunos_disciplinas = new AlunoDisciplina();

            alunos_disciplinas.listaMatriculas = _alunoDisciplinaRepository.GetMatriculasAsync().Result.GroupBy(a => a.curso).Select(g => g.First()).ToList();

            return View(alunos_disciplinas);
        }

        [HttpPost]
        public IActionResult ObterAlunos(int idCurso)
        {
            var alunos = _alunoDisciplinaRepository.GetMatriculasAsync().Result.ToList().FindAll(x => x.id_curso == idCurso);

            if(alunos.Count > 0)
            {
                alunos.Insert(0, new Matricula() { curso = "", descricao = "", id = -1, id_aluno = -1, id_curso =-1, nome = "Selecione o aluno"}) ;
            }

            return Json(alunos);
        }

        [HttpPost]
        public IActionResult ObterAnos(int idAluno)
        {
            var anos = _alunoDisciplinaRepository.GetMatriculasAsync().Result.ToList().FindAll(x => x.id_aluno == idAluno);
            /*
            if (anos.Count > 0)
            {
                anos.Insert(0, new Matricula() { curso = "", descricao = "", id = -1, id_aluno = -1, id_curso = -1, nome = "" });
            }*/

            return Json(anos);
        }

        [HttpPost]
        public IActionResult ObterDisciplinas(int idCurso)
        {
            var disciplinas = _alunoDisciplinaRepository.GetDisciplinasAsync().Result.ToList().FindAll(x => x.id_curso == idCurso);

            if (disciplinas.Count > 0)
            {
                disciplinas.Insert(0, new Disciplina() {id = -1, disciplina = "Selecione a disciplina", id_curso = -1, curso = ""});
            }

            return Json(disciplinas);
        }

        // POST: AlunosPorDisciplinasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int ano, int semestre, [Bind("id_matricula,id_aluno,id_curso,id_disciplina,nota,status")] AlunoDisciplina aluno_disciplina)
        {
            if (ModelState.IsValid)
            {
                var matricula = await _alunoDisciplinaRepository.GetMatriculaByAsync(aluno_disciplina.id_aluno, aluno_disciplina.id_curso, ano, semestre);

                aluno_disciplina.id_matricula = matricula.id;

                await _alunoDisciplinaRepository.SaveAsync(aluno_disciplina);

                return RedirectToAction(nameof(Index));
            }
            return View(aluno_disciplina);
        }

        // GET: AlunosPorDisciplinasController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno_disciplina = await _alunoDisciplinaRepository.GetAlunoPorDisciplinaByIdAsync(id);

            aluno_disciplina.listaMatriculas = _alunoDisciplinaRepository.GetMatriculasAsync().Result.GroupBy(a => a.curso).Select(g => g.First()).ToList();

            if (aluno_disciplina == null)
            {
                return NotFound();
            }
            return View(aluno_disciplina);
        }

        // POST: AlunosPorDisciplinasController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, int ano, int semestre, [Bind("id_aluno,id_curso,id_disciplina,nota,status")] AlunoDisciplina aluno_disciplina)
        {

            var matricula = await _alunoDisciplinaRepository.GetMatriculaByAsync(aluno_disciplina.id_aluno, aluno_disciplina.id_curso, ano, semestre);

            aluno_disciplina.id_matricula = matricula.id;

            aluno_disciplina.id = id;

            if (ModelState.IsValid)
            {
                try
                {
                    
                    await _alunoDisciplinaRepository.UpdateAlunoDisciplinaAsync(aluno_disciplina);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno_disciplina);
        }

        // GET: AlunosPorDisciplinasController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno_disciplina = await _alunoDisciplinaRepository.GetAlunoPorDisciplinaByIdAsync(id);

            if (aluno_disciplina == null)
            {
                return NotFound();
            }

            return View(aluno_disciplina);
        }

        // POST: AlunosPorDisciplinasController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _alunoDisciplinaRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
