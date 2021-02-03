using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
namespace Biblioteca.Services
{
    interface IUsuario
    {
        bool Remover(long ID);
        bool Salvar(Usuario user);
        Usuario GetUsuario(long ID);
        IEnumerable<Usuario> GetUsuarios { get; }
        bool Edita(Usuario user);
    }
}
