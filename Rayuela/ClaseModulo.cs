using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseModulo
    {
        private String IdModulo;
        private int Curso;
        private String Ciclo;
        private String NombreCompleto;

        public ClaseModulo()
        {
        }

        public ClaseModulo(string idModulo, int curso, string ciclo, string nombreCompleto)
        {
            this.IdModulo = idModulo;
            this.Curso = curso;
            this.Ciclo = ciclo;
            this.NombreCompleto = nombreCompleto;
        }

        public string IdModulo1 { get => IdModulo; set => IdModulo = value; }
        public int Curso1 { get => Curso; set => Curso = value; }
        public string Ciclo1 { get => Ciclo; set => Ciclo = value; }
        public string NombreCompleto1 { get => NombreCompleto; set => NombreCompleto = value; }
    }
}
