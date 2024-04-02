
namespace Rayuela
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlCiclos = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlCiclos
            // 
            this.tabControlCiclos.Location = new System.Drawing.Point(62, 31);
            this.tabControlCiclos.Name = "tabControlCiclos";
            this.tabControlCiclos.SelectedIndex = 0;
            this.tabControlCiclos.Size = new System.Drawing.Size(681, 360);
            this.tabControlCiclos.TabIndex = 0;
            this.tabControlCiclos.SelectedIndexChanged += new System.EventHandler(this.tabControlCiclos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCiclos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCiclos;
    }
}

