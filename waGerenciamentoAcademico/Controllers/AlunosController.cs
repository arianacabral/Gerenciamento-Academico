using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using waGerenciamentoAcademico.Models;
using waGerenciamentoAcademico.Repositories.Interfaces;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace waGerenciamentoAcademico.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public AlunosController(IAlunoRepository alunoRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            _alunoRepository = alunoRepositorio;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: AlunosController
        public async Task<IActionResult> Index()
        {
            var alunos = await _alunoRepository.GetAlunosAsync();

            return View(alunos);
        }

        // GET: AlunosController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _alunoRepository
                .GetAlunoByIdAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: AlunosController/Create
        public ActionResult Create()
        {
            return View();
        }

        public Aluno UploadFile(Aluno aluno, string op = "foto")
        {
            string ImagefileName = null;
            string DocfileName = null;

            string ImageFolder = @"Imagens\IALunos\";
            string DocFolder = @"Documentos\DALunos\";

            switch (op)
            {
                case "foto":

                    if (aluno.imagem != null & (aluno.imagem.ContentType == "image/jpg" | aluno.imagem.ContentType == "image/jpeg" | aluno.imagem.ContentType == "image/png"))
                    {
                        ImagefileName = Guid.NewGuid().ToString() + "-" + aluno.imagem.FileName;

                        string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, ImageFolder, ImagefileName);

                        using (var fileStream = new FileStream(uploadDir, FileMode.Create))
                        {
                            aluno.imagem.CopyTo(fileStream);
                        }

                        aluno.caminhoArquivo = Path.Combine(_webHostEnvironment.WebRootPath, ImageFolder);
                        aluno.nomeArquivo = ImagefileName;

                    }

                    break;
                case "comprovante":
                    if (aluno.comprovante != null & (aluno.comprovante.ContentType == "image/jpg" | aluno.comprovante.ContentType == "image/jpeg" | aluno.comprovante.ContentType == "application/pdf"))
                    {
                        DocfileName = Guid.NewGuid().ToString() + "-" + aluno.comprovante.FileName;

                        string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, DocFolder, DocfileName);

                        using (var fileStream = new FileStream(uploadDir, FileMode.Create))
                        {
                            aluno.comprovante.CopyTo(fileStream);
                        }

                        aluno.caminhoArquivoComprovante = Path.Combine(_webHostEnvironment.WebRootPath, DocFolder);
                        aluno.nomeArquivoComprovante = DocfileName;
                    }
                    break;
            }

            return aluno;
        }

        // POST: AlunosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno = UploadFile(aluno, "foto");

                aluno = UploadFile(aluno, "comprovante");

                await _alunoRepository.SaveAsync(aluno);

                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        public void GetFile(Aluno aluno)
        {
            string ImagefileName = null;
            string DocfileName = null;

            ImagefileName = aluno.caminhoArquivo + aluno.nomeArquivo;
            DocfileName = aluno.caminhoArquivoComprovante + aluno.nomeArquivoComprovante;

            if (ImagefileName != null || ImagefileName != "")
            {
                using (var stream = System.IO.File.OpenRead(ImagefileName))
                {
                    aluno.imagem = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
                }
            }

            if (DocfileName != null || DocfileName != "")
            {
                using (var stream = System.IO.File.OpenRead(DocfileName))
                {
                    aluno.comprovante = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
                }
            }

        }

        // GET: AlunosController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _alunoRepository.GetAlunoByIdAsync(id);

            GetFile(aluno);

            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        // POST: AlunosController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, Aluno aluno)
        {
            if (id != aluno.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (aluno.imagem != null)
                    {
                        DeleteFile(aluno, "foto");

                        aluno = UploadFile(aluno, "foto");
                    }

                    if (aluno.comprovante != null)
                    {

                        DeleteFile(aluno, "comprovante");

                        aluno = UploadFile(aluno, "comprovante");

                    }

                    await _alunoRepository.UpdateAlunoAsync(aluno);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        // GET: AlunosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _alunoRepository.GetAlunoByIdAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: AlunosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _alunoRepository.GetAlunoByIdAsync(id);

            DeleteFile(aluno,"foto");
            DeleteFile(aluno,"comprovante");

            await _alunoRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public void DeleteFile(Aluno aluno, string op = "foto")
        {
            string ImagefileName = null;
            string DocfileName = null;

            switch (op)
            {
                case "foto":
                    if ((aluno.caminhoArquivo != null | aluno.caminhoArquivo != "") & (aluno.nomeArquivo != null | aluno.nomeArquivo != ""))
                    {
                        ImagefileName = aluno.caminhoArquivo + aluno.nomeArquivo;

                        if (System.IO.File.Exists(ImagefileName))
                        {
                            System.IO.File.Delete(ImagefileName);
                        }
                    }
                    break;
                case "comprovante":
                    if ((aluno.caminhoArquivoComprovante != null | aluno.caminhoArquivoComprovante != "") & (aluno.nomeArquivoComprovante != null | aluno.nomeArquivoComprovante != ""))
                    {
                        DocfileName = aluno.caminhoArquivoComprovante + aluno.nomeArquivoComprovante;

                        if (System.IO.File.Exists(DocfileName))
                        {
                            System.IO.File.Delete(DocfileName);
                        }
                    }
                    break;

            }

        }
    }
}
