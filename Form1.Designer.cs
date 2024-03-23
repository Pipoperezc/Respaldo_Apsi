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
            this.eEstado = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tIp_Server
            // 
            this.tIp_Server.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tIp_Server.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tIp_Server.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIp_Server.ForeColor = System.Drawing.Color.White;
            this.tIp_Server.Location = new System.Drawing.Point(358, 62);
            this.tIp_Server.Name = "tIp_Server";
            this.tIp_Server.Size = new System.Drawing.Size(206, 23);
            this.tIp_Server.TabIndex = 4;
            // 
            // tDatabase
            // 
            this.tDatabase.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDatabase.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDatabase.ForeColor = System.Drawing.Color.White;
            this.tDatabase.Location = new System.Drawing.Point(358, 110);
            this.tDatabase.Name = "tDatabase";
            this.tDatabase.Size = new System.Drawing.Size(206, 23);
            this.tDatabase.TabIndex = 5;
            // 
            // tUsuario
            // 
            this.tUsuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUsuario.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.ForeColor = System.Drawing.Color.White;
            this.tUsuario.Location = new System.Drawing.Point(358, 158);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(206, 23);
            this.tUsuario.TabIndex = 6;
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.White;
            this.tPassword.Location = new System.Drawing.Point(358, 211);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(206, 23);
            this.tPassword.TabIndex = 7;
            // 
            // tArchivo
            // 
            this.tArchivo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tArchivo.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tArchivo.ForeColor = System.Drawing.Color.White;
            this.tArchivo.Location = new System.Drawing.Point(15, 256);
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(325, 23);
            this.tArchivo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP del Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de Base de Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(357, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(357, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 61);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oCalendario
            // 
            this.oCalendario.BackColor = System.Drawing.Color.Silver;
            this.oCalendario.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCalendario.Location = new System.Drawing.Point(28, 50);
            this.oCalendario.Name = "oCalendario";
            this.oCalendario.TabIndex = 15;
            this.oCalendario.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.oCalendario_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre del archivo del respaldo";
            // 
            // eEstado
            // 
            this.eEstado.AutoSize = true;
            this.eEstado.BackColor = System.Drawing.Color.Transparent;
            this.eEstado.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eEstado.ForeColor = System.Drawing.Color.White;
            this.eEstado.Location = new System.Drawing.Point(18, 287);
            this.eEstado.Name = "eEstado";
            this.eEstado.Size = new System.Drawing.Size(77, 22);
            this.eEstado.TabIndex = 17;
            this.eEstado.Text = "En Espera";
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Transparent;
            this.btnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOff.BackgroundImage")));
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(525, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(39, 42);
            this.btnOff.TabIndex = 19;
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Respaldo_Apsi.Properties.Resources.fondo_appp;
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.eEstado);
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
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.Label eEstado;
        private System.Windows.Forms.Button btnOff;
    }
}

