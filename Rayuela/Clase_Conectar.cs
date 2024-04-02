using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Rayuela
{
    class Clase_Conectar
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;
        List<ClaseAlumno> listaAlumno = new List<ClaseAlumno>();
        List<ClaseCursos> listaCursos = new List<ClaseCursos>();

        List<ClaseModulo> listaModulos = new List<ClaseModulo>();
        List<ClaseCalificaciones> listaCalificaciones = new List<ClaseCalificaciones>();
        List<ClaseFaltaAsistencia> listaFaltas = new List<ClaseFaltaAsistencia>();
        public Clase_Conectar()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;Database=rayuela;Uid=root;pwd='';old guids=true";
        }
        public List<ClaseCursos> listarCursos()
        {
            conexion.Open();
            String cadenaSql = "select * from cursos";
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseCursos cc = new ClaseCursos();
                cc.IdCurso1 = (string)datos["IdCurso"];
                cc.NombreCompleto1 = (String)datos["NombreCompleto"];
                cc.Curso1 = (int)datos["Curso"];
                cc.Ciclo1 = (String)datos["Ciclo"];
                listaCursos.Add(cc);
            }
            conexion.Close();
            return listaCursos;
        }

        internal List<ClaseAlumno> ListarAlumnosXCurso(string ciclo1, int curso1)
        {
            List<ClaseAlumno> listaXCurso = new List<ClaseAlumno>();
            conexion.Open();
            String cadenaSql = "select * from alumnos where Ciclo=?cic and Curso=?cur and Activo=1 order by Nombre";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.AddWithValue("?cic", ciclo1);
            comando.Parameters.AddWithValue("?cur", curso1);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseAlumno ca = new ClaseAlumno();
                ca.Identificador = Convert.ToString(datos["Identificador"]);
                ca.Nombre = Convert.ToString(datos["Nombre"]);
                ca.Mail = Convert.ToString(datos["mail"]);
                ca.Ciclo = Convert.ToString(datos["Ciclo"]);
                ca.Curso = Convert.ToInt16(datos["Curso"]);
                ca.Foto = Convert.ToString(datos["Foto"]);
                ca.Activo = Convert.ToInt16(datos["Activo"]);
                listaXCurso.Add(ca);
            }
            conexion.Close();
            return listaXCurso;
        }

        internal void AniadirFalta(string identificador, string modulo)

        {
            conexion.Open();
            String cadenaSql = "insert into faltasasistencia values(null, ?IdentificadorAlumno,?fecha,?modulo)";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.AddWithValue("?IdentificadorAlumno", identificador);
            comando.Parameters.AddWithValue("?fecha", DateTime.Now);
            comando.Parameters.AddWithValue("?modulo", modulo);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        internal int AniadirPuntuacion(string identificador, int puntos, string modulo)
        {
            conexion.Open();
            int codigo = 0;
            String cadenaSql = "insert into calificaciones values(null,?id,?mod,?puntos)";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.AddWithValue("?id", identificador);
            comando.Parameters.AddWithValue("?mod", modulo);
            comando.Parameters.AddWithValue("?puntos", puntos);
            codigo=comando.ExecuteNonQuery();
            conexion.Close();
            return codigo;
        }

        public List<ClaseAlumno> listarAlumnos()
        {
            conexion.Open();
            String cadenaSql = "select * from alumnos where Activo=1 order by Nombre";
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseAlumno ca = new ClaseAlumno();
                ca.Identificador = Convert.ToString(datos["Identificador"]);
                ca.Nombre = Convert.ToString(datos["Nombre"]);
                ca.Mail = Convert.ToString(datos["mail"]);
                ca.Ciclo = Convert.ToString(datos["Ciclo"]);
                ca.Curso = Convert.ToInt16(datos["Curso"]);
                ca.Foto = Convert.ToString(datos["Foto"]);
                ca.Activo = Convert.ToInt16(datos["Activo"]);
                listaAlumno.Add(ca);
            
            }
            conexion.Close();
            return listaAlumno;
            
        }
        public List<ClaseFaltaAsistencia> listadoFaltas(String idAlumno)
        {
            conexion.Open();
            String cadenaSql = "select * from faltasasistencia where Identificador=?idAl";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?idAl", MySqlDbType.VarChar).Value = idAlumno;
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseFaltaAsistencia cFa = new ClaseFaltaAsistencia();
                cFa.Indice = (int)datos["Indice"];
                cFa.Fecha1 = (string)datos["Fecha"];
                cFa.Modulo1 = (string)datos["Modulo"];
                cFa.IdentificadorAlumno1 = (string)datos["IdentificadorAlumno"];
                listaFaltas.Add(cFa);
            }
            return listaFaltas;
        }
        public List<ClaseCalificaciones> ListarCalificaciones(String identificadorAlumno)
        {
            conexion.Open();
            String cadenaSql = "select * from calificaciones where IdentificadorAlumno=?idAl";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.AddWithValue("?idAl", identificadorAlumno);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseCalificaciones cc = new ClaseCalificaciones();
                cc.Indice1 = (int)datos["Indice"];
                cc.IdentificadorAlumno1 = (string)datos["IdentificadorAlumno"];
                cc.Modulo1 = (string)datos["Modulo"];
                cc.Puntos1 = (int)datos["Puntos"];

                listaCalificaciones.Add(cc);
            }
            conexion.Close();
            return listaCalificaciones;
        }
        public List<ClaseModulo> listadoMoudulosXCursoXCiclo(string ciclo, int curso)
        {
            Console.Out.WriteLine("ciclo: " + ciclo + "curso:" + curso);
            conexion.Open();
            String cadenaSql = "select * from modulos where ciclo=?cic and curso=?cur";
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.AddWithValue("?cic", ciclo);
            comando.Parameters.Add("?cur", MySqlDbType.Int16).Value = curso;
            datos = comando.ExecuteReader();
            listaModulos.Clear();
            while (datos.Read())
            {
                ClaseModulo cm = new ClaseModulo();
                cm.IdModulo1 = (string)datos["IdModulo"];
                cm.NombreCompleto1 = (String)datos["NombreCompleto"];
                cm.Ciclo1 = (String)datos["ciclo"];
                cm.Curso1 = (int)datos["curso"];
                listaModulos.Add(cm);
            }
            conexion.Close();
            return listaModulos;
        }

        }
    }

