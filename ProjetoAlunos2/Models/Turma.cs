using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAlunos2.Models
{
    public class Turma
    {
        [Display(Name = "Código da turma")]
        public int Id { get; set; }

        public string Disciplina { get; set; }

        [Display(Name = "Horário")]
        public string Horario { get; set; }

        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma()
        {
        }

        public Turma(int id, string disciplina, string horario)
        {
            Id = id;
            Disciplina = disciplina;
            Horario = horario;
        }
    }
}
