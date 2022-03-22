
namespace CRUD.Sistema_de_Login {
    partial class LoginCadastro {
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblDicaSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(36, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(25, 63);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(94, 20);
            this.lblNomeUsuario.TabIndex = 1;
            this.lblNomeUsuario.Text = "Nome de usuário";
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.Location = new System.Drawing.Point(36, 93);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblSenhaUsuario.TabIndex = 2;
            this.lblSenhaUsuario.Text = "Senha";
            this.lblSenhaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Location = new System.Drawing.Point(36, 126);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(70, 20);
            this.lblEmailUsuario.TabIndex = 3;
            this.lblEmailUsuario.Text = "E-mail";
            this.lblEmailUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDicaSenha
            // 
            this.lblDicaSenha.Location = new System.Drawing.Point(12, 153);
            this.lblDicaSenha.Name = "lblDicaSenha";
            this.lblDicaSenha.Size = new System.Drawing.Size(94, 28);
            this.lblDicaSenha.TabIndex = 4;
            this.lblDicaSenha.Text = "Dica da senha";
            this.lblDicaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 158);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 20);
            this.textBox6.TabIndex = 9;
            // 
            // LoginCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 290);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDicaSenha);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblDicaSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
    }
}