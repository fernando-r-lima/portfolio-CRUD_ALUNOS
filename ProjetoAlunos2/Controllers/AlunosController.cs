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
                return NotFound();
            }

            var obj = _alunosService.EncontrarPorId(id.Value);
            if (obj == null)
            {
                return NotFound();
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
    }
}
