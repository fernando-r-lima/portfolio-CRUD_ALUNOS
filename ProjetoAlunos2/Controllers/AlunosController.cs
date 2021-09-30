using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Services;

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
    }
}
