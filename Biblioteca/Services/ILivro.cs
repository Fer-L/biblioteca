using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.Services
{
    interface ILivro
    {
        bool Remover(long ID);
        bool Salvar(Livro book);
        Livro GetLivro(long ID);
        IEnumerable<Livro> GetLivros { get; }
        bool Edita(Livro book);
    }
}
