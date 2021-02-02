using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class ListaDeDesejos
    {
        public long ID { get; set; }
        public long LivroId { get; set; }
        public long UsuarioId { get; set; }
    }
}
