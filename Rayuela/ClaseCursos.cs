using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseCursos
    {
        private String IdCurso;
        private String NombreCompleto;
        private String Ciclo;
        private int Curso;

        public ClaseCursos()
        {
        }

        public ClaseCursos(string idCurso, string nombreCompleto, string ciclo, int curso)
        {
            IdCurso = idCurso;
            NombreCompleto = nombreCompleto;
            Ciclo = ciclo;
            Curso = curso;
        }

        public string IdCurso1 { get => IdCurso; set => IdCurso = value; }
        public string NombreCompleto1 { get => NombreCompleto; set => NombreCompleto = value; }
        public string Ciclo1 { get => Ciclo; set => Ciclo = value; }
        public int Curso1 { get => Curso; set => Curso = value; }
    }
}
