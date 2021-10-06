using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlunos2.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Disciplina { get; set; }
        public string Semestre { get; set; }
        public string Horario { get; set; }

        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma()
        {
        }

        public Turma(int id, string disciplina, string semestre, string horario)
        {
            Id = id;
            Disciplina = disciplina;
            Semestre = semestre;
            Horario = horario;
        }
    }
}
