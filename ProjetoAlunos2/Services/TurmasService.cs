using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Data;
using ProjetoAlunos2.Models;

namespace ProjetoAlunos2.Services
{
    public class TurmasService
    {
        private readonly ProjetoAlunos2Context _context;

        public TurmasService(ProjetoAlunos2Context context)
        {
            _context = context;
        }

        public List<Turma> RetornarTodasTurmas()
        {
            return _context.Turma.OrderBy(x => x.Disciplina).ToList();
            
        }

    }
}
