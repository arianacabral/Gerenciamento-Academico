using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;
using waGerenciamentoAcademico.Repositories.Interfaces;

namespace waGerenciamentoAcademico.Controllers
{
    public class DisciplinasPorCursosController:Controller
    {
        private readonly IDisciplinaCursoRepository _disciplinaCursoRepository;

        public DisciplinasPorCursosController(IDisciplinaCursoRepository disciplinaCursoRepository)
        {
            _disciplinaCursoRepository = disciplinaCursoRepository;
        }

        // GET: DisciplinasPorCursosController
        public async Task<IActionResult> Relatorio(string Curso)
        {
            var disciplinas_cursos = await _disciplinaCursoRepository.GetDisciplinasPorCursosByCursoAsync(Curso);

            disciplinas_cursos = disciplinas_cursos.FindAll(x => x.data_desativacao == null);

            return View(disciplinas_cursos);
        }

        // GET: DisciplinasPorCursosController
        public async Task<IActionResult> Index()
        {
            return View(await _disciplinaCursoRepository.GetDisciplinasPorCursosAsync());
        }

        // GET: DisciplinasPorCursosController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina_curso = await _disciplinaCursoRepository
                .GetDisciplinaPorCursoByIdAsync(id);
            if (disciplina_curso == null)
            {
                return NotFound();
            }

            return View(disciplina_curso);
        }

        // GET: DisciplinasPorCursosController/Create
        public ActionResult Create()
        {
            DisciplinaCurso disciplinas_cursos = new DisciplinaCurso();
            disciplinas_cursos.listaCursos = _disciplinaCursoRepository.GetCursosAsync().Result.GroupBy(a => a.curso).Select(g => g.First()).ToList();
            
            /*ViewBag.Cursos = new SelectList(_disciplinaCursoRepository.GetCursosAsync().Result.ToList(), "id", "curso");
            ViewBag.Disciplinas = new SelectList(_disciplinaCursoRepository.GetDisciplinasAsync().Result.ToList(), "id", "disciplina");*/
            
            return View(disciplinas_cursos);
        }

        [HttpPost]
        public IActionResult ObterDisciplinas(int idCurso)
        {
            //System.Threading.Thread.Sleep(1000);

            var disciplinas = _disciplinaCursoRepository.GetDisciplinasAsync().Result.ToList().FindAll(x => x.id_curso == idCurso);
            /*
            if (disciplinas.Count > 0)
            {
                disciplinas.Insert(0, new Disciplina() {id = -1, disciplina = "Selecione a disciplina", id_curso = -1, curso = "", pagina = ""});
            }*/

            return Json(disciplinas);
        }

        // POST: DisciplinasPorCursosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_curso,id_disciplina,data_desativacao")] DisciplinaCurso disciplina_curso)
        {
            if (ModelState.IsValid)
            {
                await _disciplinaCursoRepository.SaveAsync(disciplina_curso);

                return RedirectToAction(nameof(Index));
            }
            return View(disciplina_curso);
        }

        // GET: DisciplinasPorCursosController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            /*
            ViewBag.Cursos = new SelectList(_disciplinaCursoRepository.GetCursosAsync().Result.ToList(), "id", "curso");
            ViewBag.Disciplinas = new SelectList(_disciplinaCursoRepository.GetDisciplinasAsync().Result.ToList(), "id", "disciplina");
            */

            if (id == null)
            {
                return NotFound();
            }

            var disciplina_curso = await _disciplinaCursoRepository.GetDisciplinaPorCursoByIdAsync(id);

            int idCurso = disciplina_curso.id_curso;

            disciplina_curso.listaCursos = _disciplinaCursoRepository.GetCursosAsync().Result.GroupBy(a => a.curso).Select(g => g.First()).ToList().FindAll(x => x.id == idCurso);

            if (disciplina_curso == null)
            {
                return NotFound();
            }
            return View(disciplina_curso);
        }

        // POST: DisciplinasPorCursosController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("id_curso,id_disciplina,data_desativacao")] DisciplinaCurso disciplina_curso)
        {
            disciplina_curso.id = id;

            if (ModelState.IsValid)
            {
                try
                {
                    await _disciplinaCursoRepository.UpdateDisciplinaCursoAsync(disciplina_curso);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(disciplina_curso);
        }

        // GET: DisciplinasPorCursosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina_curso = await _disciplinaCursoRepository.GetDisciplinaPorCursoByIdAsync(id);

            if (disciplina_curso == null)
            {
                return NotFound();
            }

            return View(disciplina_curso);
        }

        // POST: DisciplinasPorCursosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _disciplinaCursoRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
