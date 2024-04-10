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
using System.Configuration;
using System.Collections.Specialized;

namespace Respaldo_Apsi
{
    public partial class frm_Principal : Form
    {

        public frm_Principal()
        {
            InitializeComponent();
            // tIp_Server.Text = "CONTA-PC\\SQLEXPRESS";
            tIp_Server.Text = ConfigurationManager.AppSettings.Get("server") ;
            tDatabase.Text = ConfigurationManager.AppSettings.Get("database");
            tUsuario.Text = ConfigurationManager.AppSettings.Get("usuario");
            tPassword.Text = ConfigurationManager.AppSettings.Get("password");
            tCarpeta.Text =  ConfigurationManager.AppSettings.Get("carpeta_resp");
            Selecciona_Dia();
            Carga_Directorio();

         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

                

        private void button3_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Realizar el Respaldo de la base de datos?", "Realizar Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (respuesta == DialogResult.No)
            {
                return;
            }
            
            
            // asignacion de los parametros de la conexion con la base de datos 
            string lcIP = tIp_Server.Text.Trim();
            string lcDatabase = tDatabase.Text.Trim();
            string lcUser = tUsuario.Text.Trim();
            string lcPass = tPassword.Text.Trim();
       


            // Asignacion del nombre del archivo 
            string lcNom_Archivo = tArchivo.Text.Trim().ToLower();
            string lcCarpeta = tCarpeta.Text.Trim();

            string lcQuery = "BACKUP DATABASE [APSISISTEMAS] TO  DISK = N'I:/"+lcCarpeta+"/"+lcNom_Archivo+"' WITH NOFORMAT, NOINIT,  NAME = N'APSISISTEMAS-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            string lcConString = "Data Source=" + lcIP + ";Database="+lcDatabase+"; uid="+lcUser+"; pwd="+lcPass+";";
         
           //  using (SqlConnection oConexion = new SqlConnection(oCnString.ConnectionString))
            
            using (SqlConnection oConexion = new SqlConnection(lcConString))
            {
                try
                {
                    Application.DoEvents();
                    eEstado.Text = "Conectando la Base de Datos...";
                    eEstado.Refresh();
                    oConexion.Open();
                    Application.DoEvents();
                    eEstado.Text = "Respaldo en ejecución...";
                    eEstado.Refresh();
                    Application.DoEvents();
                    SqlCommand oComando = new SqlCommand(lcQuery, oConexion);
                    oComando.ExecuteNonQuery();
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoriamente",
            "Copia de seguridad de base de datos",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    oConexion.Close();
                    eEstado.Text = "Respaldo Realizado";
                    Carga_Directorio();
                }
                catch (Exception oError) 
                {
                    MessageBox.Show(oError.Message,
           "Error al copiar la base de datos",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
          

            };

        }


        private void Selecciona_Dia()
        {//Selecciona_Dia
           
            // Selecciona el dia del calendario para crear el nombre del archivo y ponerlo en el text_box
            DateTime dFecha = oCalendario.SelectionRange.Start;

            string lcDia = dFecha.Day.ToString();
            string lcMes = dFecha.ToString("MMMMM");
            string lcAnio = dFecha.Year.ToString();

            string lcNom_Archivo = "RESPALDO_APSI_" + lcDia + "_" + lcMes + "_" + lcAnio + ".BAK";
            tArchivo.Text = lcNom_Archivo.Trim().ToLower();
        }//Selecciona_Dia


        private void oCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            Selecciona_Dia();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Carga_Directorio() 
        { // Carga_Directorio

            String lcCarpeta = "";

            lcCarpeta = tCarpeta.Text.Trim();

            String lcRuta = "\\\\90.0.0.9\\"+lcCarpeta+"\\";
            lArchivos.Items.Clear();
            DirectoryInfo lDirectorio_Respaldos = new DirectoryInfo(@lcRuta);
            foreach (var item in lDirectorio_Respaldos.GetFiles()) 
            {
                lArchivos.Items.Add(item.Name);
            }

        } // Carga_Directorio

        private void cmdCopiaArchivo_Click(object sender, EventArgs e)
        {
            if (lArchivos.SelectedItem == null)
            {
                MessageBox.Show("No Existe ningun archivo seleccionado de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string lcDestino = "";

            FolderBrowserDialog oDialogo = new FolderBrowserDialog();

            oDialogo.ShowNewFolderButton = true;

            DialogResult oResultado = oDialogo.ShowDialog();


            if (oResultado == DialogResult.No || oResultado == DialogResult.Cancel)
                {
                return;
            }


            string lcCarpeta_Destino = oDialogo.SelectedPath;
            
            lcDestino = lcCarpeta_Destino+"\\" + lArchivos.SelectedItem.ToString().Trim();
          
            String lcCarpeta = "";

            lcCarpeta = tCarpeta.Text.Trim();

            String lcRuta = "\\\\90.0.0.9\\" + lcCarpeta + "\\";

            string lcOrigen = lcRuta + lArchivos.SelectedItem.ToString().Trim();

            try
            {
                if (File.Exists(lcOrigen) && !File.Exists(lcDestino))
                {
                    FileInfo arch_Copiar = new FileInfo(lcOrigen);
                    Application.DoEvents();
                    eEstado.Text = "Copiando Archivos por favor espere ...";
                    eEstado.Refresh();

                    arch_Copiar.CopyTo(lcDestino);
                    MessageBox.Show("Archivo Copiado Exitosamente", "Archivo Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.DoEvents();
                    eEstado.Text = "Archivo Copiado";
                    eEstado.Refresh();

                }

                else
                {
                    MessageBox.Show("El Archivo no se encuentra o la carpeta de destino no esta definido","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            catch (Exception oError)
            {
                MessageBox.Show(oError.Message,
       "Error al copiar la base de datos",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
