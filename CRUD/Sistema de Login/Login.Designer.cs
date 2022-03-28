
namespace CRUD.Sistema_de_Login {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.btnLoginStatus = new System.Windows.Forms.Button();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoginDica = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtLoginUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUsuario.Location = new System.Drawing.Point(159, 93);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(124, 20);
            this.txtLoginUsuario.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(159, 140);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(124, 20);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnLoginEntrar.Location = new System.Drawing.Point(13, 180);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(68, 44);
            this.btnLoginEntrar.TabIndex = 3;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            this.btnLoginEntrar.Click += new System.EventHandler(this.btnLoginEntrar_Click);
            // 
            // btnLoginStatus
            // 
            this.btnLoginStatus.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnLoginStatus.Location = new System.Drawing.Point(161, 180);
            this.btnLoginStatus.Name = "btnLoginStatus";
            this.btnLoginStatus.Size = new System.Drawing.Size(68, 44);
            this.btnLoginStatus.TabIndex = 5;
            this.btnLoginStatus.Text = "Verificar Status";
            this.btnLoginStatus.UseVisualStyleBackColor = true;
            this.btnLoginStatus.Click += new System.EventHandler(this.btnLoginStatus_Click);
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.BackColor = System.Drawing.Color.White;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblEsqueceuSenha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(13, 259);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(290, 20);
            this.lblEsqueceuSenha.TabIndex = 7;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEsqueceuSenha.Click += new System.EventHandler(this.lblEsqueceuSenha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUD.Properties.Resources.avatar;
            this.pictureBox2.Location = new System.Drawing.Point(134, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 61);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CRUD.Properties.Resources.minus;
            this.pictureBox1.Location = new System.Drawing.Point(13, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginDica
            // 
            this.btnLoginDica.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnLoginDica.Location = new System.Drawing.Point(235, 180);
            this.btnLoginDica.Name = "btnLoginDica";
            this.btnLoginDica.Size = new System.Drawing.Size(68, 44);
            this.btnLoginDica.TabIndex = 6;
            this.btnLoginDica.Text = "Dica senha";
            this.btnLoginDica.UseVisualStyleBackColor = true;
            this.btnLoginDica.Click += new System.EventHandler(this.btnLoginDica_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCriarConta.Location = new System.Drawing.Point(87, 180);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(68, 44);
            this.btnCriarConta.TabIndex = 4;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 290);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.btnLoginDica);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.btnLoginStatus);
            this.Controls.Add(this.btnLoginEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.Button btnLoginStatus;
        private System.Windows.Forms.Label lblEsqueceuSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoginDica;
        private System.Windows.Forms.Button btnCriarConta;
    }
}