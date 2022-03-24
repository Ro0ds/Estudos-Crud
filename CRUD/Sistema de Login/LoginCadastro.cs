using System;
using System.Data;
using System.Data.SqlClient;
using CRUD.Banco_de_Dados;
using CRUD.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class LoginCadastro : Form {
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        SqlDataReader reader;
        public LoginCadastro() {
            InitializeComponent();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e) {
            foreach (Control c in this.Controls) {
                if (c is TextBox && c.Tag == "CadastroTXT" && c.Text == string.Empty) {
                    MessageBox.Show("Preencha os campos corretamente", "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;
                }
                else if (c is TextBox && c.Tag == "CadastroTXT" && c.Text != string.Empty) { 

                }
            }
        }

        private void btnLimparRegistro_Click(object sender, EventArgs e) {
            foreach (Control c in this.Controls) {
                if (c is TextBox && c.Tag == "CadastroTXT" && c.Text != string.Empty) {
                    c.Text = string.Empty;
                }
                else {
                    MessageBox.Show("Sem conteúdo para limpar.", "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}