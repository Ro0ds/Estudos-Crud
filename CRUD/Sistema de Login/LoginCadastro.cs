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
        VerificacaoConfig vConf = new VerificacaoConfig();
        private bool isActive = false;
        string CheckStatus, conn;

        public LoginCadastro() {
            InitializeComponent();

            vConf.VerificaIni();
            conn = vConf.ArquivoINI.Read("StrCon");

            DBInfo = new DatabaseInfo(conn);
            DBInfo.SetarConexao(conn);
        }

        public void CarregaDados() {
            if (chkAtivo.CheckState == CheckState.Checked && chkInativo.CheckState == CheckState.Unchecked) {
                isActive = true;
                CheckStatus = "ativo";
            }
            else if (chkAtivo.CheckState == CheckState.Unchecked && chkInativo.CheckState == CheckState.Checked) {
                isActive = false;
                CheckStatus = "inativo";
            }
            else if (chkAtivo.CheckState == CheckState.Unchecked && chkInativo.CheckState == CheckState.Unchecked) {
                isActive = false;
                MessageBox.Show("Erro: nenhuma opção marcada", "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (chkAtivo.CheckState == CheckState.Checked && chkInativo.CheckState == CheckState.Checked) {
                isActive = false;
                MessageBox.Show("Erro: duas opções marcadas, utilize apenas uma para escolher", "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            DBInternal = new DatabaseInternal(
                    txtCadastroNome.Text,
                    txtCadastroNomeUser.Text,
                    txtCadastroSenha.Text,
                    txtCadastroEmail.Text,
                    txtCadastroDica.Text
                );
        }

        private void LoginCadastro_Load(object sender, EventArgs e) {
            CarregaDados();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e) {
            if (isEmpty()) {
                MessageBox.Show("Preencha os campos corretamente.", "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else {
                CarregaDados();
                DBInternal.LStatusUsuario = CheckStatus;

                DBInfo.sqlcmd = $"INSERT INTO Login VALUES ('{DBInternal.LNome}', '{DBInternal.LNomeUsuario}', '{DBInternal.LSenhaUsuario}', '{DBInternal.LEmailUsuario}', '{DBInternal.LDicaSenhaUsuario}' ,'{DBInternal.LStatusUsuario}')";

                try {
                    DBInfo.AbrirConexão();

                    int ex = DBInfo.cmd.ExecuteNonQuery();

                    if(ex > 0) {
                        MessageBox.Show("Usuário inserido com sucesso!", "Aviso | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        LimpaCampos();
                    }
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Login Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally {
                    DBInfo.con.Close();
                    DBInfo.con.Dispose();
                }
            }
        }

        private void btnLimparRegistro_Click(object sender, EventArgs e) {
            LimpaCampos();
        }

        public bool isEmpty() {
            if (txtCadastroNome.Text == string.Empty && txtCadastroNomeUser.Text == string.Empty && txtCadastroSenha.Text == string.Empty && txtCadastroEmail.Text == string.Empty && txtCadastroDica.Text == string.Empty) {
                return true;
            }
            else {
                return false;
            }
        }


        public void LimpaCampos() {
            txtCadastroNome.Text = string.Empty;
            txtCadastroNomeUser.Text = string.Empty;
            txtCadastroSenha.Text = string.Empty;
            txtCadastroEmail.Text = string.Empty;
            txtCadastroDica.Text = string.Empty;
        }
    }
}