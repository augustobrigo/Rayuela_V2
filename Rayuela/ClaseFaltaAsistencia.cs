using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseFaltaAsistencia
    {
        private int indice;
        private String IdentificadorAlumno;
        private String Fecha;
        private String Modulo;

        public ClaseFaltaAsistencia()
        {
        }

        public ClaseFaltaAsistencia(int indice, string identificadorAlumno, string fecha, string modulo)
        {
            this.indice = indice;
            IdentificadorAlumno = identificadorAlumno;
            Fecha = fecha;
            Modulo = modulo;
        }

        public int Indice { get => indice; set => indice = value; }
        public string IdentificadorAlumno1 { get => IdentificadorAlumno; set => IdentificadorAlumno = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string Modulo1 { get => Modulo; set => Modulo = value; }
    }
}
