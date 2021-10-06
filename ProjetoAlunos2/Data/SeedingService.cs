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
            if (_context.Aluno.Any() || _context.Turma.Any())
            {
                return; //Db já populado
            }

            Aluno a1 = new Aluno(1, "Fernando", "Azevedo", new DateTime(1995, 6, 10), "fernando.Az@gmail.com", 2);
            Aluno a2 = new Aluno(2, "Luiz Roberto", "Gouveia", new DateTime(1995, 8, 12), "lr.gouveia@uol.com", 2);
            Aluno a3 = new Aluno(3, "Juliana", "Silva", new DateTime(1994, 2, 9), "ju_silva94@yahoo.com", 1);
            Aluno a4 = new Aluno(4, "Felipe", "Carvalho", new DateTime(1995, 1, 24), "felipe-carvalho@gmail.com", 2);
            Aluno a5 = new Aluno(5, "Amanda", "Lima", new DateTime(1993, 4, 15), "mandy-lima@yahoo.com", 1);
            Aluno a6 = new Aluno(6, "Luiz Augusto", "Alcântara", new DateTime(1993, 5, 8), "luizAlc@gmail.com", 1);
            Aluno a7 = new Aluno(7, "Fabiano", "Santos", new DateTime(1993, 7, 8), "santos-fabiano@gmail.com",3 );
            Aluno a8 = new Aluno(8, "Augusto", "Souza", new DateTime(1994, 3, 9), "augusto@gmail.com", 4);
            Aluno a9 = new Aluno(9, "Marcela", "Medeiros", new DateTime(1995, 11, 23), "marcela-med@gmail.com", 4);
            Aluno a10 = new Aluno(10, "Rafael", "Aguiar da Nobrega", new DateTime(1994, 5, 14), "rafa.aguiar@gmail.com", 3);
            Aluno a11 = new Aluno(11, "Luiz Henrique", "Justino de Almeida", new DateTime(1994, 6, 8), "henrique.lu94@gmail.com", 3);
            Aluno a12 = new Aluno(12, "Flaviana", "Souza", new DateTime(1993, 12, 10), "souzaflaviana@gmail.com", 4);

            Turma t1 = new Turma(1, "DESENHO I", "2018.1", "QUA 10:00-12:00");
            Turma t2 = new Turma(2, "TIPOGRAFIA", "2018.1", "QUI 08:00-10:00");
            Turma t3 = new Turma(3, "DESENHO I", "2018.2", "SEG 10:00-12:00");
            Turma t4 = new Turma(4, "TIPOGRAFIA", "2018.2", "QUI 10:00-12:00");


            _context.Aluno.AddRange(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);
            _context.Turma.AddRange(t1, t2, t3, t4);

            _context.SaveChanges();
        }
    }
}
