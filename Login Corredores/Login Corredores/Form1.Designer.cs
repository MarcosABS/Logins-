namespace Login_Corredores
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCodigoIntermediario = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(41, 32);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(54, 16);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Location = new System.Drawing.Point(41, 96);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(76, 16);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Intermediario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(180, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(180, 96);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(130, 22);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtCodigoIntermediario
            // 
            this.txtCodigoIntermediario.Location = new System.Drawing.Point(180, 156);
            this.txtCodigoIntermediario.Name = "txtCodigoIntermediario";
            this.txtCodigoIntermediario.Size = new System.Drawing.Size(130, 22);
            this.txtCodigoIntermediario.TabIndex = 5;
            // 
            // botonLogin
            // 
            this.botonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonLogin.Location = new System.Drawing.Point(114, 222);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(121, 50);
            this.botonLogin.TabIndex = 6;
            this.botonLogin.Text = "Iniciar Session";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 336);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.txtCodigoIntermediario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.Usuario);
            this.Name = "form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCodigoIntermediario;
        private System.Windows.Forms.Button botonLogin;
    }
}

