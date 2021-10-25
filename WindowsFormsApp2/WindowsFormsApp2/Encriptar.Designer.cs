
namespace WindowsFormsApp2
{
    partial class Encriptar
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblAbrir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(56, 55);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(121, 26);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir ubucacion ";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblAbrir
            // 
            this.lblAbrir.Location = new System.Drawing.Point(56, 146);
            this.lblAbrir.Multiline = true;
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAbrir.Size = new System.Drawing.Size(167, 69);
            this.lblAbrir.TabIndex = 1;
            this.lblAbrir.Text = ",,,,,,,,";
            this.lblAbrir.TextChanged += new System.EventHandler(this.lblAbrir_TextChanged);
            // 
            // Encriptar
            // 
            this.ClientSize = new System.Drawing.Size(303, 324);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Encriptar";
            this.Load += new System.EventHandler(this.Encriptar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox lblAbrir;
    }
}

