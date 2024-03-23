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

            Selecciona_Dia();

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
            string lcQuery = "BACKUP DATABASE [APSISISTEMAS] TO  DISK = N'I:/resp_databases_apsi/"+lcNom_Archivo+"' WITH NOFORMAT, NOINIT,  NAME = N'APSISISTEMAS-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            string lcConString = "Data Source=" + lcIP + ";Database="+lcDatabase+"; uid="+lcUser+"; pwd="+lcPass+";";
         
           //  using (SqlConnection oConexion = new SqlConnection(oCnString.ConnectionString))
            
            using (SqlConnection oConexion = new SqlConnection(lcConString))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand oComando = new SqlCommand(lcQuery, oConexion);
                    oComando.ExecuteNonQuery();
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoriamente",
            "Copia de seguridad de base de datos",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    oConexion.Close();
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
    }
}
