using Microsoft.AspNetCore.Mvc;
using ProjetoAlunos2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlunos2.Controllers
{
    public class TurmasController : Controller
    {

        private readonly TurmasService _turmasService;

        public TurmasController(TurmasService turmasService)
        {
            _turmasService = turmasService;
        }

        public IActionResult Index()
        {
            var list = _turmasService.RetornarTodasTurmas();
            return View(list);
        }
    }
}
