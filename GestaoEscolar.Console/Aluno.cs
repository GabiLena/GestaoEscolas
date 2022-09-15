using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoEscolar.CLI
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Aula> Aulas { get; set; }

    }
}
