using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAlunos2.Models
{
    public class Aluno
    {

        [Display(Name = "Matrícula")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Código da turma")]
        public int TurmaId { get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string sobrenome, DateTime dataDeNascimento, string email, int turmaId)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataDeNascimento = dataDeNascimento;
            Email = email;
            TurmaId = turmaId;
        }
    }
}
