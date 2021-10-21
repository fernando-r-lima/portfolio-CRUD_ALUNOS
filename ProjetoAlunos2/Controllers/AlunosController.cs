using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Services;
using ProjetoAlunos2.Models;
using ProjetoAlunos2.Models.ViewModels;


namespace ProjetoAlunos2.Controllers
{
    public class AlunosController : Controller
    {

        private readonly AlunosService _alunosService;
        private readonly TurmasService _turmasService;

        public AlunosController(AlunosService alunosService, TurmasService turmasService)
        {
            _alunosService = alunosService;
            _turmasService = turmasService;
        }

        public IActionResult Index()
        {
            var list = _alunosService.RetornarTodosAlunos();
            return View(list);
        }

        public IActionResult Create()
        {
            var turmas = _turmasService.RetornarTodasTurmas();
            var viewModel = new FormularioAlunoViewModel { Turmas = turmas };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Aluno aluno)
        {
            _alunosService.CadastrarAluno(aluno);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido para fazer exclusão" });

            }

            var obj = _alunosService.EncontrarPorId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id de aluno inexistente" });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _alunosService.ExcluirAluno(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                //return NotFound();
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido para mostrar os detalhes" });
            }

            var obj = _alunosService.EncontrarPorId(id.Value);
            if (obj == null)
            {
                //return NotFound();
                return RedirectToAction(nameof(Error), new { message = "Id de aluno inexistente" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido para fazer edição" });
            }

            var obj = _alunosService.EncontrarPorId(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id de aluno inexistente" });
            }

            var turmas = _turmasService.RetornarTodasTurmas();
            var viewModel = new FormularioAlunoViewModel { Aluno = obj, Turmas = turmas };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Aluno aluno)
        {
            _alunosService.AtualizarDados(aluno);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel { Message = message };
            return View(viewModel);
        }
    }
}
