using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Livro
    {
        public long ID { get; set; }
        public bool Lido { get; set; }
        public long EstanteID { get; set; }
        public string Editora { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int SituacaoDeEmprestimo { get; set; }
    }
}
