
namespace CRUD.Sistema_de_Login {
    partial class SenhaRecuperacao {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailRecupera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCodigoRecupera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificaRecupera = new System.Windows.Forms.Button();
            this.TempoParaRecuperar = new System.Windows.Forms.Timer(this.components);
            this.txtNomeUsuarioRecupera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeRecupera = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetaSenha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira seu e-mail:";
            // 
            // txtEmailRecupera
            // 
            this.txtEmailRecupera.Location = new System.Drawing.Point(146, 100);
            this.txtEmailRecupera.Name = "txtEmailRecupera";
            this.txtEmailRecupera.Size = new System.Drawing.Size(149, 20);
            this.txtEmailRecupera.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recuperação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(15, 131);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(280, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCodigoRecupera
            // 
            this.txtCodigoRecupera.Enabled = false;
            this.txtCodigoRecupera.Location = new System.Drawing.Point(15, 184);
            this.txtCodigoRecupera.Name = "txtCodigoRecupera";
            this.txtCodigoRecupera.Size = new System.Drawing.Size(278, 20);
            this.txtCodigoRecupera.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código de recuperação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificaRecupera
            // 
            this.btnVerificaRecupera.Enabled = false;
            this.btnVerificaRecupera.Location = new System.Drawing.Point(15, 210);
            this.btnVerificaRecupera.Name = "btnVerificaRecupera";
            this.btnVerificaRecupera.Size = new System.Drawing.Size(278, 23);
            this.btnVerificaRecupera.TabIndex = 6;
            this.btnVerificaRecupera.Text = "Verificar";
            this.btnVerificaRecupera.UseVisualStyleBackColor = true;
            this.btnVerificaRecupera.Click += new System.EventHandler(this.btnVerificaRecupera_Click);
            // 
            // TempoParaRecuperar
            // 
            this.TempoParaRecuperar.Interval = 1000;
            this.TempoParaRecuperar.Tick += new System.EventHandler(this.TempoParaRecuperar_Tick);
            // 
            // txtNomeUsuarioRecupera
            // 
            this.txtNomeUsuarioRecupera.Location = new System.Drawing.Point(146, 72);
            this.txtNomeUsuarioRecupera.Name = "txtNomeUsuarioRecupera";
            this.txtNomeUsuarioRecupera.Size = new System.Drawing.Size(149, 20);
            this.txtNomeUsuarioRecupera.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insira seu Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insira seu Nome:";
            // 
            // txtNomeRecupera
            // 
            this.txtNomeRecupera.Location = new System.Drawing.Point(146, 45);
            this.txtNomeRecupera.Name = "txtNomeRecupera";
            this.txtNomeRecupera.Size = new System.Drawing.Size(149, 20);
            this.txtNomeRecupera.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetaSenha);
            this.groupBox1.Controls.Add(this.txtSenha2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(19, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alteração de senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(24, 39);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(236, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha nova:";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(24, 82);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(236, 20);
            this.txtSenha2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Digite novamente";
            // 
            // btnResetaSenha
            // 
            this.btnResetaSenha.Location = new System.Drawing.Point(23, 108);
            this.btnResetaSenha.Name = "btnResetaSenha";
            this.btnResetaSenha.Size = new System.Drawing.Size(237, 23);
            this.btnResetaSenha.TabIndex = 10;
            this.btnResetaSenha.Text = "Resetar senha";
            this.btnResetaSenha.UseVisualStyleBackColor = true;
            this.btnResetaSenha.Click += new System.EventHandler(this.btnResetaSenha_Click);
            // 
            // SenhaRecuperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNomeUsuarioRecupera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeRecupera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerificaRecupera);
            this.Controls.Add(this.txtCodigoRecupera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailRecupera);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SenhaRecuperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senha Recuperacao";
            this.Load += new System.EventHandler(this.SenhaRecuperacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailRecupera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtCodigoRecupera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificaRecupera;
        private System.Windows.Forms.Timer TempoParaRecuperar;
        private System.Windows.Forms.TextBox txtNomeUsuarioRecupera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeRecupera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetaSenha;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
    }
}