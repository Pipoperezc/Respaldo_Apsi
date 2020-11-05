namespace Respaldo_Apsi
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
            this.lArchivos = new System.Windows.Forms.ListBox();
            this.tDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tIp_Server = new System.Windows.Forms.TextBox();
            this.tDatabase = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tArchivo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lArchivos
            // 
            this.lArchivos.FormattingEnabled = true;
            this.lArchivos.Location = new System.Drawing.Point(12, 40);
            this.lArchivos.Name = "lArchivos";
            this.lArchivos.Size = new System.Drawing.Size(366, 173);
            this.lArchivos.TabIndex = 1;
            // 
            // tDirectorio
            // 
            this.tDirectorio.Location = new System.Drawing.Point(66, 14);
            this.tDirectorio.Name = "tDirectorio";
            this.tDirectorio.Size = new System.Drawing.Size(271, 20);
            this.tDirectorio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directorio";
            // 
            // tIp_Server
            // 
            this.tIp_Server.Location = new System.Drawing.Point(472, 40);
            this.tIp_Server.Name = "tIp_Server";
            this.tIp_Server.Size = new System.Drawing.Size(206, 20);
            this.tIp_Server.TabIndex = 4;
            // 
            // tDatabase
            // 
            this.tDatabase.Location = new System.Drawing.Point(472, 89);
            this.tDatabase.Name = "tDatabase";
            this.tDatabase.Size = new System.Drawing.Size(206, 20);
            this.tDatabase.TabIndex = 5;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(472, 128);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(206, 20);
            this.tUsuario.TabIndex = 6;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(472, 174);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(206, 20);
            this.tPassword.TabIndex = 7;
            // 
            // tArchivo
            // 
            this.tArchivo.Location = new System.Drawing.Point(12, 219);
            this.tArchivo.Name = "tArchivo";
            this.tArchivo.Size = new System.Drawing.Size(325, 20);
            this.tArchivo.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Image = global::Respaldo_Apsi.Properties.Resources.save;
            this.button2.Location = new System.Drawing.Point(341, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Respaldo_Apsi.Properties.Resources.open;
            this.button1.Location = new System.Drawing.Point(345, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 21);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP del Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de Base de Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tArchivo);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tDatabase);
            this.Controls.Add(this.tIp_Server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDirectorio);
            this.Controls.Add(this.lArchivos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lArchivos;
        private System.Windows.Forms.TextBox tDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tIp_Server;
        private System.Windows.Forms.TextBox tDatabase;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tArchivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

