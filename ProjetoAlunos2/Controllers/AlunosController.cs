using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Services;
using ProjetoAlunos2.Models;

namespace ProjetoAlunos2.Controllers
{
    public class AlunosController : Controller
    {

        private readonly AlunosService _alunosService;

        public AlunosController(AlunosService alunosService)
        {
            _alunosService = alunosService;
        }

        public IActionResult Index()
        {
            var list = _alunosService.RetornarTodosAlunos();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
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
