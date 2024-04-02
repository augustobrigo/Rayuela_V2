using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class Form1 : Form
    {
        Clase_Conectar cnx = new Clase_Conectar();
        List<ClaseCursos> listaCursos = new List<ClaseCursos>();
        List<ClaseAlumno> listaAlumnos = new List<ClaseAlumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCursos = cnx.listarCursos();
           // listaAlumnos = cnx.listarAlumnos();
            cargarAulas(listaCursos,listaAlumnos);
        }

        private void cargarAulas(List<ClaseCursos> listaCursos,List<ClaseAlumno> listaAlumnos)
        {
            //número de cursos = número de pestañas creada programatically
            int nCursos = listaCursos.Count;
            for (int i = 0; i < nCursos; i++)
            {
                //cargar las pestañas de cursos
                TabPage tpCurso = new TabPage(listaCursos[i].IdCurso1);
                //listado de alumnos de ciclo: ASIR curso: 2
                List<ClaseAlumno> listaAlumnosXCurso = new List<ClaseAlumno>();
                listaAlumnosXCurso = cnx.ListarAlumnosXCurso(listaCursos[i].Ciclo1,listaCursos[i].Curso1);
                //añadir tpCurso a su contenedor padre inmediato
                //tabControl es el único componente creado con el diseñador
                tabControlCiclos.Controls.Add(tpCurso);
                //cargar los alumnos por cada curso
                TableLayoutPanel tlp = new TableLayoutPanel();
                //que se redimensione en función a la lista autosize=true.
                //tamaña de tlp va en función al contenido de la lista
                tlp.AutoSize = true;
                //limito el número de columnas a 5
                tlp.ColumnCount = 5;
                
                  //montar los alumnos por por curso
                  for (int j = 0; j < listaAlumnosXCurso.Count; j++)
                {
                    //contenedor uno por alumno, dentro tendrá: etiqueta nombre, botón imagen
                    FlowLayoutPanel flp = new FlowLayoutPanel();
                    //diseño del flp
                    flp.AutoSize = true;
                    flp.BackColor=Color.LightBlue;
                    //los componentes se organizan de arriba a abajo.
                    flp.FlowDirection = FlowDirection.TopDown;
                    //nombre
                    Label lblNombre = new Label();
                    lblNombre.Text = listaAlumnosXCurso[j].Nombre;
                    flp.Controls.Add(lblNombre);
                    // botón imagen
                    Button btnImagen = new Button();
                    btnImagen.Width = 50;
                    btnImagen.Height = 50;
                    //guardar todo el objeto alumno dentro de la propiedad TAG
                    btnImagen.Tag = listaAlumnosXCurso[j];
                    //añadir evento de forma programatically
                    btnImagen.Click += BtnImagen_Click;
                    //añadir el botón al contenedor superior
                    flp.Controls.Add(btnImagen);
                    //descargar la imagen. La clase WebClient permite  convertir
                    //un string en array de bytes
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(listaAlumnosXCurso[j].Foto);
                    //crear una secuencia en memoria auxiliar a partir del array de bytes
                    MemoryStream ms = new MemoryStream(bytes);
                    //convertir en imagen el fluyo de bytes
                    System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
                    btnImagen.BackgroundImage = imagen;
                    //adapta el tamaño de la imagen al contenedor (botón)
                    btnImagen.BackgroundImageLayout = ImageLayout.Stretch;

                    //añadir el flow (card alumno) dentro del table (tabla curso)
                    tlp.Controls.Add(flp);
                 }
                //añadir al contenedor contenedor padre inmediato: tpCurso
                tpCurso.Controls.Add(tlp);

            }
        
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            Button botonX = (Button)sender;
            ClaseAlumno ca = (ClaseAlumno)botonX.Tag;
            //modificar el constructor de Detalle alumno (parámetro ClaseAlumno)
            //poner pública la claseAlumno
            DetalleAlumno da = new DetalleAlumno(ca);
            
            da.ShowDialog();
        }

        private void tabControlCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
