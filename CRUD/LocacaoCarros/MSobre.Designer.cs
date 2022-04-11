
namespace CRUD.LocacaoCarros {
    partial class MSobre {
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
            this.PainelSobre = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PainelSobre
            // 
            this.PainelSobre.BackColor = System.Drawing.Color.White;
            this.PainelSobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelSobre.Location = new System.Drawing.Point(0, 0);
            this.PainelSobre.Name = "PainelSobre";
            this.PainelSobre.Size = new System.Drawing.Size(934, 745);
            this.PainelSobre.TabIndex = 0;
            // 
            // MSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 745);
            this.Controls.Add(this.PainelSobre);
            this.Name = "MSobre";
            this.Text = "Sobre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelSobre;
    }
}