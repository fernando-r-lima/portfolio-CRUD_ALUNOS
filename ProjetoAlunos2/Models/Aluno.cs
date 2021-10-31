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

        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, ErrorMessage = "{0} deve ter no máximo 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} é necessário")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "{0} é necessário")]
        [EmailAddress(ErrorMessage = "Forneça um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Turma Turma { get; set; }

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
