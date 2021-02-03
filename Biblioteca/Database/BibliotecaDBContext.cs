using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Database
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options)
        {

        }

        DbSet<Emprestimo> Emprestimos { get; set; }
        DbSet<Estante> Estantes { get; set; }
        DbSet<ListaDeDesejos> ListaDeDesejos { get; set; }
        DbSet<Livro> Livros { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
    }
}
