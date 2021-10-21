using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            //return _context.Aluno.ToList();
            return _context.Aluno.Include(obj => obj.Turma).OrderBy(obj => obj.Id).ToList();
        }

        public void CadastrarAluno(Aluno obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Aluno EncontrarPorId(int id)
        {
            //return _context.Aluno.FirstOrDefault(obj => obj.Id == id);
            return _context.Aluno.Include(obj => obj.Turma).FirstOrDefault(obj => obj.Id == id);
        }

        public void ExcluirAluno(int id)
        {
            var obj = _context.Aluno.Find(id);
            _context.Aluno.Remove(obj);
            _context.SaveChanges();
        }

        public void AtualizarDados(Aluno obj)
        {
            _context.Update(obj);
            _context.SaveChanges();

        }
    }
}
