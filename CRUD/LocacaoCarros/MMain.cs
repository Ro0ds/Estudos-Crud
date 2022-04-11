using System;
using System.Drawing;
using CRUD.Banco_de_Dados;
using CRUD.LocacaoCarros;
using CRUD.Sistema_de_Login;
using System.Windows.Forms;

namespace CRUD.LocacaoCarros {
    public partial class MMain : Form {
        private Form activeForm;
        public MMain() {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender) {
            if (activeForm != null) {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PainelPrincipal.Controls.Add(childForm);
            this.PainelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e) {
            OpenChildForm(new LocacaoCarros.MPrincipal(), sender);
        }

        private void btnCarros_Click(object sender, EventArgs e) {
            OpenChildForm(new LocacaoCarros.MCarros(), sender);
        }

        private void btnFidelidade_Click(object sender, EventArgs e) {
            OpenChildForm(new LocacaoCarros.MFidelidade(), sender);
        }

        private void btnPerfil_Click(object sender, EventArgs e) {
            OpenChildForm(new LocacaoCarros.MPerfil(), sender);
        }

        private void btnSobre_Click(object sender, EventArgs e) {
            OpenChildForm(new LocacaoCarros.MSobre(), sender);
        }
    }
}