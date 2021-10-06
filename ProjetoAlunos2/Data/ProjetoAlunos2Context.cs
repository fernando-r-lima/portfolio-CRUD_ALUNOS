using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoAlunos2.Models;

namespace ProjetoAlunos2.Data
{
    public class ProjetoAlunos2Context : DbContext
    {
        public ProjetoAlunos2Context (DbContextOptions<ProjetoAlunos2Context> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<Turma> Turma { get; set; }
    }
}
