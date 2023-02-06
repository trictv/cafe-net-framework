using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Models;

namespace Cafe.Dados
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuarios { set; get; }

        public DbSet<Alimento> Alimentos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Estrutura> Estruturas { get; set; }

        public DbSet<Variacao> Variacoes { get; set; }
    }
}
