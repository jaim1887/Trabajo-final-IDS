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
    public partial class Desencriptar : Form
    {
        public Desencriptar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;

           /* byte[] encrypted = File.ReadAllBytes(vRutaArchivo);
            using (var DES = new DESCryptoServiceProvider())
            {


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(vRutaArchivo, memStream.ToArray());
                    textBox1.Text=("Su archivo ha sido desencriptado correctamente " + vRutaArchivo);

                }

            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
