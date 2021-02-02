using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Estante
    {
        public long Id { get; set; }
        public int QuantidadeTotalDeLivros { get; set; }
        public int QuantidadeDeLivrosLidos { get; set; }
    }
}
