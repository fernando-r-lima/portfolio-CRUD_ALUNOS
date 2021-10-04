using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Data;
using ProjetoAlunos2.Models;

namespace ProjetoAlunos2.Services
{
    public class AlunosService
    {
        private readonly ProjetoAlunos2Context _context;

        public AlunosService(ProjetoAlunos2Context context)
        {
            _context = context;
        }

        public List<Aluno> RetornarTodosAlunos()
        {
            return _context.Aluno.ToList();
        }

        public void CadastrarAluno(Aluno obj) 
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
