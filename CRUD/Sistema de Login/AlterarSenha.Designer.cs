
namespace CRUD.Sistema_de_Login {
    partial class AlterarSenha {
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
            this.btnAlteraSenha = new System.Windows.Forms.Button();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtRepitaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlteraSenha
            // 
            this.btnAlteraSenha.Location = new System.Drawing.Point(12, 62);
            this.btnAlteraSenha.Name = "btnAlteraSenha";
            this.btnAlteraSenha.Size = new System.Drawing.Size(221, 37);
            this.btnAlteraSenha.TabIndex = 0;
            this.btnAlteraSenha.Text = "Alterar senha";
            this.btnAlteraSenha.UseVisualStyleBackColor = true;
            this.btnAlteraSenha.Click += new System.EventHandler(this.btnAlteraSenha_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(97, 10);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(136, 20);
            this.txtNovaSenha.TabIndex = 1;
            // 
            // txtRepitaSenha
            // 
            this.txtRepitaSenha.Location = new System.Drawing.Point(97, 36);
            this.txtRepitaSenha.Name = "txtRepitaSenha";
            this.txtRepitaSenha.Size = new System.Drawing.Size(136, 20);
            this.txtRepitaSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repita a senha:";
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepitaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.btnAlteraSenha);
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlteraSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtRepitaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}