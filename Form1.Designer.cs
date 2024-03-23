namespace Respaldo_Apsi
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tIp_Server = new System.Windows.Forms.TextBox();
            this.tDatabase = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.oCalendario = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tIp_Server
            // 
            this.tIp_Server.Location = new System.Drawing.Point(358, 77);
            this.tIp_Server.Name = "tIp_Server";
            this.tIp_Server.Size = new System.Drawing.Size(206, 20);
            this.tIp_Server.TabIndex = 4;
            // 
            // tDatabase
            // 
            this.tDatabase.Location = new System.Drawing.Point(358, 126);
            this.tDatabase.Name = "tDatabase";
            this.tDatabase.Size = new System.Drawing.Size(206, 20);
            this.tDatabase.TabIndex = 5;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(358, 165);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(206, 20);
            this.tUsuario.TabIndex = 6;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(358, 211);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(206, 20);
            this.tPassword.TabIndex = 7;
            // 
            // tArchivo
            // 
            this.tArchivo.Location = new System.Drawing.Point(15, 256);
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(325, 20);
            this.tArchivo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP del Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de Base de Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Respaldar la Base de Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oCalendario
            // 
            this.oCalendario.Location = new System.Drawing.Point(38, 58);
            this.oCalendario.Name = "oCalendario";
            this.oCalendario.TabIndex = 15;
            this.oCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.oCalendario_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre del archivo del respaldo";
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Location = new System.Drawing.Point(24, 293);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(56, 13);
            this.lEstado.TabIndex = 17;
            this.lEstado.Text = "En Espera";
            // 
            // btnOff
            // 
            this.btnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOff.BackgroundImage")));
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(538, 18);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(26, 27);
            this.btnOff.TabIndex = 19;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oCalendario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tArchivo);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tDatabase);
            this.Controls.Add(this.tIp_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldo de Base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tIp_Server;
        private System.Windows.Forms.TextBox tDatabase;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MonthCalendar oCalendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Button btnOff;
    }
}

