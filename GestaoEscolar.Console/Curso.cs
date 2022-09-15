using System.Collections.Generic;

namespace GestaoEscolar.CLI
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Aula> Aulas { get; set; }
        public int EscolaId { get; set; }
    }
}