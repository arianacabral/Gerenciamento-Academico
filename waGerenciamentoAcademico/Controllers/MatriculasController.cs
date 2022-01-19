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
    public class MatriculasController:Controller
    {
        private readonly IMatriculaRepository _matriculaRepository;

        public MatriculasController(IMatriculaRepository matriculaRepositorio)
        {
            _matriculaRepository = matriculaRepositorio;
        }

        // GET: MatriculasController
        public async Task<IActionResult> Index()
        {
            return View(await _matriculaRepository.GetMatriculasAsync());
        }

        // GET: MatriculasController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _matriculaRepository
                .GetMatriculaByIdAsync(id);
            if (matricula == null)
            {
                return NotFound();
            }

            return View(matricula);
        }

        // GET: MatriculasController/Create
        public ActionResult Create()
        {
            ViewBag.Alunos = new SelectList(_matriculaRepository.GetAlunosAsync().Result.ToList(),"id","nome");
            ViewBag.Cursos = new SelectList(_matriculaRepository.GetCursosAsync().Result.ToList(), "id", "curso");
            return View();
        }

        // POST: AlunosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_aluno,id_curso,ano,semestre")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                await _matriculaRepository.SaveAsync(matricula);

                return RedirectToAction(nameof(Index));
            }
            return View(matricula);
        }

        // GET: MatriculasController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Alunos = new SelectList(_matriculaRepository.GetAlunosAsync().Result.ToList(), "id", "nome");
            ViewBag.Cursos = new SelectList(_matriculaRepository.GetCursosAsync().Result.ToList(), "id", "curso");

            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _matriculaRepository.GetMatriculaByIdAsync(id);

            if (matricula == null)
            {
                return NotFound();
            }
            return View(matricula);
        }

        // POST: MatriculasController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("id,id_aluno,id_curso,ano,semestre")] Matricula matricula)
        {
            if (id != matricula.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _matriculaRepository.UpdateMatriculaAsync(matricula);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(matricula);
        }

        // GET: MatriculasController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _matriculaRepository.GetMatriculaByIdAsync(id);

            if (matricula == null)
            {
                return NotFound();
            }

            return View(matricula);
        }

        // POST: MatriculasController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _matriculaRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
