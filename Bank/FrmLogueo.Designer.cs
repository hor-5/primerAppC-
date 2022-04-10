namespace Bank
{
    partial class FrmLogueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogueo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(232, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(141, 175);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(80, 30);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtClave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtClave.Location = new System.Drawing.Point(96, 113);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '°';
            this.txtClave.PlaceholderText = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(120, 23);
            this.txtClave.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.Location = new System.Drawing.Point(96, 69);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = " Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNotificacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotificacion.Location = new System.Drawing.Point(279, 349);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Padding = new System.Windows.Forms.Padding(5);
            this.lblNotificacion.Size = new System.Drawing.Size(174, 30);
            this.lblNotificacion.TabIndex = 1;
            this.lblNotificacion.Text = "Notificacion de ingreso";
            this.lblNotificacion.Visible = false;
            // 
            // imgLogin
            // 
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgLogin.InitialImage")));
            this.imgLogin.Location = new System.Drawing.Point(12, 66);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(214, 241);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 2;
            this.imgLogin.TabStop = false;
            // 
            // FrmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogueo";
            this.Text = "Iniciar Sesion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIngresar;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Label lblNotificacion;
        private PictureBox imgLogin;
    }
}