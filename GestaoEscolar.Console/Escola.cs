using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoEscolar.CLI
{
    public class Escola
    {
        public List<Curso> Cursos { get; set; }
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
    }
}
