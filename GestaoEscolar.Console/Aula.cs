using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoEscolar.CLI
{
    public class Aula
    {
        public int CursoId { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
