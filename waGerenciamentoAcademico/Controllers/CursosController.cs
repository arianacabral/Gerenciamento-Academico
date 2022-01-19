using Microsoft.AspNetCore.Authorization;
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
    public class CursosController : Controller
    {
        private const int _qtdeItens = 5;

        private readonly ICursoRepository _cursoRepository;

        public CursosController(ICursoRepository cursoRepositorio)
        {
            _cursoRepository = cursoRepositorio;
        }

        // GET: CursosController
        public async Task<IActionResult> Index()
        {
            var cursos = await _cursoRepository.GetCursosAsync();

            ViewBag.QtdTotalItens = cursos.Count();
            ViewBag.QtdItens = _qtdeItens;

            if(ViewBag.QtdTotalItens % ViewBag.QtdItens == 0)
            {
                ViewBag.TotalPags = ViewBag.QtdTotalItens / ViewBag.QtdItens;
            }
            else
            {
                ViewBag.TotalPags = (ViewBag.QtdTotalItens / ViewBag.QtdItens) + 1;
            }

            List<SelectListItem> listaPaginas = new List<SelectListItem>();

            for (int i = 1; i <= ViewBag.TotalPags; i++)
            {
                if (i == 1)
                {
                    listaPaginas.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString(), Selected = true });
                }
                else
                {
                    listaPaginas.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
                }

            }

            ViewBag.Paginas = new SelectList(listaPaginas, "Value", "Text");

            var selecao = await _cursoRepository.GetCursosByLimitAsync(1, _qtdeItens);

            return View(selecao);
        }

        [HttpPost]
        public async Task<IActionResult> List (string pagina = "1")
        {
            var cursos = await _cursoRepository.GetCursosAsync();

            ViewBag.QtdTotalItens = cursos.Count();
            ViewBag.QtdItens = _qtdeItens;

            if (ViewBag.QtdTotalItens % ViewBag.QtdItens == 0)
            {
                ViewBag.TotalPags = ViewBag.QtdTotalItens / ViewBag.QtdItens;
            }
            else
            {
                ViewBag.TotalPags = (ViewBag.QtdTotalItens / ViewBag.QtdItens) + 1;
            }

            List<SelectListItem> listaPaginas = new List<SelectListItem>();

            for (int i = 1; i <= ViewBag.TotalPags; i++)
            {
                if (i == 1)
                {
                    listaPaginas.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString(), Selected = true });
                }
                else
                {
                    listaPaginas.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
                }

            }

            ViewBag.Paginas = new SelectList(listaPaginas, "Value", "Text");

            var selecao = await _cursoRepository.GetCursosByLimitAsync(int.Parse(pagina), _qtdeItens);

            return View(selecao);
        }

        // GET: CursosController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso_ = await _cursoRepository
                .GetCursoByIdAsync(id);
            if (curso_ == null)
            {
                return NotFound();
            }

            return View(curso_);
        }

        // GET: CursosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursosController/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id,curso")] Curso curso_)
        {
            if (ModelState.IsValid)
            {
                await _cursoRepository.SaveAsync(curso_);

                return RedirectToAction(nameof(Index));
            }
            return View(curso_);
        }

        // GET: CursosController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso_ = await _cursoRepository.GetCursoByIdAsync(id);

            if (curso_ == null)
            {
                return NotFound();
            }
            return View(curso_);
        }

        // POST: CursosController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("id,curso")] Curso curso_)
        {
            if (id != curso_.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _cursoRepository.UpdateCursoAsync(curso_);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(curso_);
        }

        // GET: CursosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso_ = await _cursoRepository.GetCursoByIdAsync(id);

            if (curso_ == null)
            {
                return NotFound();
            }

            return View(curso_);
        }

        // POST: CursosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _cursoRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
