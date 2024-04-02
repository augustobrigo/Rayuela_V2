
namespace Rayuela
{
    partial class DetalleAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.btnInformar = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbModulos = new System.Windows.Forms.ComboBox();
            this.cmbPuntuacion = new System.Windows.Forms.ComboBox();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnPuntuacion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(4, 9);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(75, 13);
            this.lblIdentificador.TabIndex = 0;
            this.lblIdentificador.Text = "lblIdentificador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "lblNombre";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(25, 86);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(44, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "lblCurso";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(93, 86);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(40, 13);
            this.lblCiclo.TabIndex = 3;
            this.lblCiclo.Text = "lblCiclo";
            // 
            // btnInformar
            // 
            this.btnInformar.Location = new System.Drawing.Point(157, 43);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(75, 23);
            this.btnInformar.TabIndex = 6;
            this.btnInformar.Text = "Informar";
            this.btnInformar.UseVisualStyleBackColor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(97, 10);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "lblMail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmbModulos
            // 
            this.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulos.FormattingEnabled = true;
            this.cmbModulos.Location = new System.Drawing.Point(28, 280);
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.Size = new System.Drawing.Size(121, 21);
            this.cmbModulos.TabIndex = 9;
            // 
            // cmbPuntuacion
            // 
            this.cmbPuntuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuntuacion.FormattingEnabled = true;
            this.cmbPuntuacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPuntuacion.Location = new System.Drawing.Point(28, 322);
            this.cmbPuntuacion.Name = "cmbPuntuacion";
            this.cmbPuntuacion.Size = new System.Drawing.Size(121, 21);
            this.cmbPuntuacion.TabIndex = 10;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(157, 280);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnAsistencia.TabIndex = 11;
            this.btnAsistencia.Text = "No Asiste";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnPuntuacion
            // 
            this.btnPuntuacion.Location = new System.Drawing.Point(157, 322);
            this.btnPuntuacion.Name = "btnPuntuacion";
            this.btnPuntuacion.Size = new System.Drawing.Size(75, 23);
            this.btnPuntuacion.TabIndex = 12;
            this.btnPuntuacion.Text = "Puntuar";
            this.btnPuntuacion.UseVisualStyleBackColor = true;
            this.btnPuntuacion.Click += new System.EventHandler(this.btnPuntuacion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(28, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(204, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DetalleAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPuntuacion);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.cmbPuntuacion);
            this.Controls.Add(this.cmbModulos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnInformar);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdentificador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DetalleAlumno";
            this.Text = "DetalleAlumno";
            this.Load += new System.EventHandler(this.DetalleAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Button btnInformar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbModulos;
        private System.Windows.Forms.ComboBox cmbPuntuacion;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnPuntuacion;
        private System.Windows.Forms.Button btnCerrar;
    }
}