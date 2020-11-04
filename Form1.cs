using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Respaldo_Apsi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CargaArchivos("c:\\copias");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lcDirectorio = "";
            FolderBrowserDialog oDialogo = new FolderBrowserDialog();
            if (oDialogo.ShowDialog() == DialogResult.OK)
            {
                lcDirectorio = oDialogo.SelectedPath;
                tDirectorio.Text = lcDirectorio;
                CargaArchivos(lcDirectorio);
            }
        }


        private void CargaArchivos(string lcDirectorio) 
        {// CargaArchivos
            if (Directory.Exists(lcDirectorio))
            {// Directo
                DirectoryInfo odInfo = new DirectoryInfo(@lcDirectorio);
                FileInfo[] files = odInfo.GetFiles("*.jpg");
                foreach (FileInfo oArchivo in files)
                {
                    lArchivos.Items.Add(oArchivo.Name);
                }
            }
            else 
            {
                MessageBox.Show("No existe el Directorio" + lcDirectorio,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }// CargaArchivos
    }
}
