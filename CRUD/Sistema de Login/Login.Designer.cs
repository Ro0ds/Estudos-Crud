
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
            this.menuLogin = new System.Windows.Forms.MenuStrip();
            this.menuOP1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteDB = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLoginUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUsuario.Location = new System.Drawing.Point(159, 118);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(124, 23);
            this.txtLoginUsuario.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(159, 165);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(124, 23);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnLoginEntrar.Location = new System.Drawing.Point(42, 215);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(102, 34);
            this.btnLoginEntrar.TabIndex = 2;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            this.btnLoginEntrar.Click += new System.EventHandler(this.btnLoginEntrar_Click);
            // 
            // btnLoginStatus
            // 
            this.btnLoginStatus.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnLoginStatus.Location = new System.Drawing.Point(150, 215);
            this.btnLoginStatus.Name = "btnLoginStatus";
            this.btnLoginStatus.Size = new System.Drawing.Size(102, 34);
            this.btnLoginStatus.TabIndex = 3;
            this.btnLoginStatus.Text = "Verificar Status";
            this.btnLoginStatus.UseVisualStyleBackColor = true;
            this.btnLoginStatus.Click += new System.EventHandler(this.btnLoginStatus_Click);
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.BackColor = System.Drawing.Color.White;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Comic Sans MS", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(12, 284);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(271, 20);
            this.lblEsqueceuSenha.TabIndex = 4;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEsqueceuSenha.Click += new System.EventHandler(this.lblEsqueceuSenha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUD.Properties.Resources.avatar;
            this.pictureBox2.Location = new System.Drawing.Point(115, 36);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuLogin
            // 
            this.menuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOP1});
            this.menuLogin.Location = new System.Drawing.Point(0, 0);
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(296, 24);
            this.menuLogin.TabIndex = 9;
            this.menuLogin.Text = "menuStrip1";
            // 
            // menuOP1
            // 
            this.menuOP1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateDB,
            this.menuSelectDB,
            this.menuDeleteDB});
            this.menuOP1.Name = "menuOP1";
            this.menuOP1.ShortcutKeyDisplayString = "Ctrl+F1";
            this.menuOP1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.menuOP1.Size = new System.Drawing.Size(104, 20);
            this.menuOP1.Text = "Banco de Dados";
            // 
            // menuCreateDB
            // 
            this.menuCreateDB.Name = "menuCreateDB";
            this.menuCreateDB.ShortcutKeyDisplayString = "F1";
            this.menuCreateDB.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuCreateDB.Size = new System.Drawing.Size(180, 22);
            this.menuCreateDB.Text = "Criar DB";
            this.menuCreateDB.Click += new System.EventHandler(this.menuCreateDB_Click);
            // 
            // menuSelectDB
            // 
            this.menuSelectDB.Name = "menuSelectDB";
            this.menuSelectDB.ShortcutKeyDisplayString = "F2";
            this.menuSelectDB.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuSelectDB.Size = new System.Drawing.Size(180, 22);
            this.menuSelectDB.Text = "Selecionar DB";
            this.menuSelectDB.Click += new System.EventHandler(this.menuSelectDB_Click);
            // 
            // menuDeleteDB
            // 
            this.menuDeleteDB.Name = "menuDeleteDB";
            this.menuDeleteDB.ShortcutKeyDisplayString = "F3";
            this.menuDeleteDB.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuDeleteDB.Size = new System.Drawing.Size(180, 22);
            this.menuDeleteDB.Text = "Excluir DB";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 311);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.btnLoginStatus);
            this.Controls.Add(this.btnLoginEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.menuLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuLogin;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuLogin.ResumeLayout(false);
            this.menuLogin.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuOP1;
        private System.Windows.Forms.ToolStripMenuItem menuCreateDB;
        private System.Windows.Forms.ToolStripMenuItem menuSelectDB;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteDB;
    }
}