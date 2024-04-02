using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
   public class ClaseAlumno
    {
        String identificador;
        String nombre;
        String mail;
        String ciclo;
        int curso;
        String foto;
        int activo;

        public ClaseAlumno()
        {
        }

        public ClaseAlumno(string identificador, string nombre, string mail, string ciclo, int curso, string foto, int activo)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.mail = mail;
            this.ciclo = ciclo;
            this.curso = curso;
            this.foto = foto;
            this.activo = activo;
        }

        public string Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}
