using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.Services
{
    interface IEstante
    {
        bool Remover(long ID);
        bool Criar(long UsuarioID);       
        bool Edita(Estante estante);
    }
}
