
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
            this.txtNomeRecupera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TempoParaRecuperar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira seu e-mail:";
            // 
            // txtEmailRecupera
            // 
            this.txtEmailRecupera.Location = new System.Drawing.Point(146, 71);
            this.txtEmailRecupera.Name = "txtEmailRecupera";
            this.txtEmailRecupera.Size = new System.Drawing.Size(149, 20);
            this.txtEmailRecupera.TabIndex = 2;
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
            this.btnEnviar.Location = new System.Drawing.Point(15, 97);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(280, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCodigoRecupera
            // 
            this.txtCodigoRecupera.Enabled = false;
            this.txtCodigoRecupera.Location = new System.Drawing.Point(15, 165);
            this.txtCodigoRecupera.Name = "txtCodigoRecupera";
            this.txtCodigoRecupera.Size = new System.Drawing.Size(278, 20);
            this.txtCodigoRecupera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código de recuperação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificaRecupera
            // 
            this.btnVerificaRecupera.Enabled = false;
            this.btnVerificaRecupera.Location = new System.Drawing.Point(15, 191);
            this.btnVerificaRecupera.Name = "btnVerificaRecupera";
            this.btnVerificaRecupera.Size = new System.Drawing.Size(278, 23);
            this.btnVerificaRecupera.TabIndex = 5;
            this.btnVerificaRecupera.Text = "Verificar";
            this.btnVerificaRecupera.UseVisualStyleBackColor = true;
            this.btnVerificaRecupera.Click += new System.EventHandler(this.btnVerificaRecupera_Click);
            // 
            // txtNomeRecupera
            // 
            this.txtNomeRecupera.Location = new System.Drawing.Point(146, 45);
            this.txtNomeRecupera.Name = "txtNomeRecupera";
            this.txtNomeRecupera.Size = new System.Drawing.Size(149, 20);
            this.txtNomeRecupera.TabIndex = 1;
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
            // TempoParaRecuperar
            // 
            this.TempoParaRecuperar.Interval = 1000;
            this.TempoParaRecuperar.Tick += new System.EventHandler(this.TempoParaRecuperar_Tick);
            // 
            // SenhaRecuperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 224);
            this.Controls.Add(this.txtNomeRecupera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerificaRecupera);
            this.Controls.Add(this.txtCodigoRecupera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailRecupera);
            this.Controls.Add(this.label1);
            this.Name = "SenhaRecuperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senha Recuperacao";
            this.Load += new System.EventHandler(this.SenhaRecuperacao_Load);
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
        private System.Windows.Forms.TextBox txtNomeRecupera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TempoParaRecuperar;
    }
}