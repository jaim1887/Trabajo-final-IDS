using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class Encriptar: Form
    {
        public Encriptar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;

            //el boton de busqueda se llama btnAbrir
            //conectarlo abajo 

            
            string vRutaArchivo = openFileDialog1.FileName;

            

            byte[] plainContent = File.ReadAllBytes(vRutaArchivo);
            using (var DES = new DESCryptoServiceProvider())
            {


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(vRutaArchivo, memStream.ToArray());
                    lblAbrir.Text = ("Su archivo ha sido desencriptado correctamente " + vRutaArchivo;

                }

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Encriptar_Load(object sender, EventArgs e)
        {

        }

        private void lblAbrir_TextChanged(object sender, EventArgs e)
        {

        }
        
       
    }
}
