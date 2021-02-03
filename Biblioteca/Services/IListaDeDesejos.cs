using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
namespace Biblioteca.Services
{
    interface IListaDeDesejos
    {
        bool RemoverLivro(long LivroID, long UsuarioID);
        bool Limpar(long UsuarioID);
        bool Salvar(Livro book);
        IEnumerable<Livro> GetLivros(long UsuarioID);
    }
}
