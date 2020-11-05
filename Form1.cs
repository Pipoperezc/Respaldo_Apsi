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
            tIp_Server.Text = "90.0.0.80";
            tDatabase.Text = "APSISISTEMAS";
            tUsuario.Text = "sa";
            tPassword.Text = "apsi";
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
                
                CargaArchivos(lcDirectorio);
            }
        }


        private void CargaArchivos(string lcDirectorio) 
        {// CargaArchivos
            if (Directory.Exists(lcDirectorio))
            {// Directory
                tDirectorio.Text = lcDirectorio;
                DirectoryInfo odInfo = new DirectoryInfo(@lcDirectorio);
                FileInfo[] files = odInfo.GetFiles("*.jpg");
                foreach (FileInfo oArchivo in files)
                {
                    lArchivos.Items.Add(oArchivo.Name);
                }
            } // Directory
            else 
            {
                MessageBox.Show("No existe el Directorio" + lcDirectorio,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }// CargaArchivos

        private void button2_Click(object sender, EventArgs e)
        {//Click
            string lcDirectorio = tDirectorio.Text.Trim();
            SaveFileDialog oDialogoSave = new SaveFileDialog();
            oDialogoSave.InitialDirectory = "@lcDirectorio";
            oDialogoSave.Title = "Guardar Archivo Respaldo";
            oDialogoSave.CheckFileExists = false;
            oDialogoSave.CheckPathExists = true;
            oDialogoSave.DefaultExt = "bak";
            oDialogoSave.Filter = "Bakup Archivos (*.bak)|*.bak|All files (*.*)|*.*";
            oDialogoSave.FilterIndex = 2;
            oDialogoSave.RestoreDirectory = true;
            if (oDialogoSave.ShowDialog() == DialogResult.OK)
            {

                tArchivo.Text = oDialogoSave.FileName;

            }
        }//Click

        private void button3_Click(object sender, EventArgs e)
        {

            string lcIP = tIp_Server.Text.Trim();
            string lcDatabase = tDatabase.Text.Trim();
            string lcUser = tUsuario.Text.Trim();
            string lcPass = tPassword.Text.Trim();
            string lcRuta = tArchivo.Text.ToLower();
            string lcQuery = "Backup database " + lcDatabase + " to disk = '" + lcRuta + "'";
            
            string lcConString = "Data Source=" + lcIP + ";Database="+lcDatabase+";data source=.; uid="+lcUser+"; pwd="+lcPass+";";
            SqlConnection oConexion = new SqlConnection(lcConString);
            oConexion.Open();
            SqlCommand oComando = new SqlCommand(lcQuery,oConexion);
            oComando.ExecuteNonQuery();



        }
    }
}
