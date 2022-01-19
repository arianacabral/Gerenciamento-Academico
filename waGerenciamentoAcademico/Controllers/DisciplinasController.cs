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
    public class DisciplinasController : Controller
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinasController(IDisciplinaRepository disciplinaRepositorio)
        {
            _disciplinaRepository = disciplinaRepositorio;
        }

        // GET: AlunosController
        public async Task<IActionResult> Index()
        {
            return View(await _disciplinaRepository.GetDisciplinasAsync());
        }
       
        // GET: AlunosController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina = await _disciplinaRepository
                .GetDisciplinaByIdAsync(id);
            if (disciplina == null)
            {
                return NotFound();
            }

            return View(disciplina);
        }

        // GET: AlunosController/Create
        public ActionResult Create()
        {
            ViewBag.Cursos = new SelectList(_disciplinaRepository.GetCursosAsync().Result.ToList(), "id", "curso");
            return View();
        }

        // POST: AlunosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("disciplina,id_curso")] Disciplina disciplina_)
        {
            if (ModelState.IsValid)
            {
                await _disciplinaRepository.SaveAsync(disciplina_);

                return RedirectToAction(nameof(Index));
            }
            return View(disciplina_);
        }

        // GET: AlunosController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           SelectList list = new SelectList(_disciplinaRepository.GetCursosAsync().Result.ToList(), "id", "curso");

            ViewBag.Cursos = list;

            if (id == null)
            {
                return NotFound();
            }

            var disciplina_ = await _disciplinaRepository.GetDisciplinaByIdAsync(id);

            if (disciplina_ == null)
            {
                return NotFound();
            }
            return View(disciplina_);
        }

        // POST: AlunosController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("disciplina,id_curso")] Disciplina disciplina_)
        {
            disciplina_.id = id;

            if (ModelState.IsValid)
            {
                try
                {
                    await _disciplinaRepository.UpdateDisciplinaAsync(disciplina_);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(disciplina_);
        }

        // GET: AlunosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplina_ = await _disciplinaRepository.GetDisciplinaByIdAsync(id);

            if (disciplina_ == null)
            {
                return NotFound();
            }

            return View(disciplina_);
        }

        // POST: AlunosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _disciplinaRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
