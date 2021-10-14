using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAlunos2.Models.ViewModels
{
    public class FormularioAlunoViewModel
    {
        public Aluno Aluno { get; set; }
        
        [Display(Name = "Turma")]
        public ICollection<Turma> Turmas { get; set; }

    }
}
