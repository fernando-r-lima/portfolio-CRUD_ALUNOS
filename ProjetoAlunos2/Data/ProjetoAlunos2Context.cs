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

        public DbSet<ProjetoAlunos2.Models.Aluno> Aluno { get; set; }
    }
}
