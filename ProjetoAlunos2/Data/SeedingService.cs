using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAlunos2.Models;

namespace ProjetoAlunos2.Data
{
    public class SeedingService
    {

        private ProjetoAlunos2Context _context;

        public SeedingService(ProjetoAlunos2Context context)
        {
            _context = context;
        }

        public void PopularDb()
        {
            if (_context.Aluno.Any())
            {
                return; //Db já populado
            }

            Aluno a1 = new Aluno(1, "Fernando", "Azevedo", new DateTime(1995, 6, 10), "fernando.Az@gmail.com");
            Aluno a2 = new Aluno(2, "Luiz Roberto", "Gouveia", new DateTime(1995, 8, 12), "lr.gouveia@uol.com");
            Aluno a3 = new Aluno(3, "Juliana", "Silva", new DateTime(1994, 2, 9), "ju_silva94@yahoo.com");
            Aluno a4 = new Aluno(4, "Felipe", "Carvalho", new DateTime(1995, 1, 24), "felipe-carvalho@gmail.com");
            Aluno a5 = new Aluno(5, "Amanda", "Lima", new DateTime(1993, 4, 15), "mandy-lima@yahoo.com");
            Aluno a6 = new Aluno(6, "Luiz Augusto", "Alcântara", new DateTime(1993, 5, 8), "luizAlc@gmail.com");

            _context.Aluno.AddRange(a1, a2, a3, a4, a5, a6);

            _context.SaveChanges();
        }
    }
}
