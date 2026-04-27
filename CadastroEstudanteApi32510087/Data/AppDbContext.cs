using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroEstudanteApi32510087.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroEstudanteApi32510087.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Estudante> Estudantes { get; set; }
    }
}