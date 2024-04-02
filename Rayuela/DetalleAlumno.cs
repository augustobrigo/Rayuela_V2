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
    public partial class DetalleAlumno : Form
    {
        ClaseAlumno alumno;
        List<ClaseModulo> listaModulos = new List<ClaseModulo>();
        Clase_Conectar cnx = new Clase_Conectar();
        public DetalleAlumno(ClaseAlumno al)
        {
            InitializeComponent();
            this.alumno = al;
        }

        private void DetalleAlumno_Load(object sender, EventArgs e)
        {
            Console.Out.WriteLine("nombre alumno" + this.alumno.Nombre);
            lblCiclo.Text = this.alumno.Ciclo;
            lblCurso.Text = this.alumno.Curso.ToString();
            lblMail.Text = this.alumno.Mail;
            lblIdentificador.Text = this.alumno.Identificador;
            lblNombre.Text = this.alumno.Nombre;
            System.Net.WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(alumno.Foto);
            System.IO.MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
            //cargar los módulos de un alumno en un comboBox
            Console.Out.WriteLine("Módulos" + listaModulos.Count);
            listaModulos = cnx.listadoMoudulosXCursoXCiclo(this.alumno.Ciclo, this.alumno.Curso);
            for (int k = 0; k < listaModulos.Count; k++){
                Console.Out.WriteLine(listaModulos[k].IdModulo1);
                cmbModulos.Items.Add(listaModulos[k].IdModulo1);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPuntuacion_Click(object sender, EventArgs e)
        {
            if (cmbModulos.Text!="" && cmbPuntuacion.Text != "")
            {
               int codigo= cnx.AniadirPuntuacion(alumno.Identificador, Convert.ToInt16(cmbPuntuacion.Text), cmbModulos.Text);
                if (codigo == 1)
                {
                    MessageBox.Show("Puntuaciones añadidas correctamente");
                }
                else
                {
                    MessageBox.Show("error al añadir");
                }
            }
         }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if (cmbModulos.Text != "")
            {
                cnx.AniadirFalta(alumno.Identificador, cmbModulos.Text);
            }
        }
    }
}
