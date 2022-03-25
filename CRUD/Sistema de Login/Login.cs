using System;
using System.Data;
using System.Data.SqlClient;
using CRUD.Banco_de_Dados;
using CRUD.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class Login : Form {
        List<string> infos;
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        SqlDataReader reader;
        VerificacaoConfig vConf = new VerificacaoConfig();
        DialogResult dg;
        readonly string cName = "CRUD.Properties.Settings.CRUDConnectionString";
        string conn;

        /* 
         * IDENTIFICAÇÃO DOS CÓDIGOS NA LISTA
         * 
         * 0 = COD_USUARIO
         * 1 = NOME
         * 2 = NOME_USUARIO
         * 3 = SENHA_USUARIO
         * 4 = EMAIL_USUARIO
         * 5 = DICA_SENHA_USUARIO
         * 6 = SITUACAO
         * 
         */

        public Login() {
            InitializeComponent();

            //Verifica se o arquivo INI existe no diretório, caso não ele irá criar
            vConf.VerificaIni();

            //atribui a string de conexão do banco de dados que está setado no arquivo INI
            conn = vConf.ArquivoINI.Read("StrCon");

            //Inicia uma nova instancia do DBInfo, para configurar a conexão com o banco de dados
            DBInfo = new DatabaseInfo(conn);

            //Inicia uma nova configuração para alterar o App.Config, possibilitando assim uma futuro implementação de troca de banco
            AppSetting cfg = new AppSetting();
            cfg.SaveConnectionString(cName, conn); //Salva a configuração no arquivo

            //Chama o método que possibilita a conexão do banco de dados a partir de qualquer classe
            //Obs: só é possível alterar a string de conexão utilizando o método SetarConexao(string stringconexao)
            DBInfo.SetarConexao(conn);
        }

        public void CarregaDados() {
            DBInternal = new DatabaseInternal(
                    txtLoginUsuario.Text,
                    txtLoginPassword.Text
                );
        }

        private void Login_Load(object sender, EventArgs e) {
            CarregaDados();
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e) {
            if (txtLoginUsuario.Text == string.Empty || txtLoginPassword.Text == string.Empty) {
                MessageBox.Show($"Campo não preenchido corretamente", "Erro | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaDados();
            infos = new List<string>();

            DBInfo.sqlcmd = $"SELECT * FROM Login WHERE nome_usuario = '{DBInternal.LNomeUsuario}' and senha_usuario = '{DBInternal.LSenhaUsuario}'";

            try {
                //AbreConexao();
                DBInfo.AbrirConexão();

                reader = DBInfo.cmd.ExecuteReader();

                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        infos.Add(reader[i].ToString());
                    }
                }

                if (!reader.HasRows) {
                    MessageBox.Show($"Usuário não encontrado ou inválido, tente novamente", "Erro | Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (DBInternal.LNomeUsuario == infos[2] && DBInternal.LSenhaUsuario == infos[3]) {
                    MessageBox.Show($"Bem vindo(a) {infos[1]}. \nLogin realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main mForm = new Main();
                    mForm.Show();
                }
                else {
                    dg = MessageBox.Show($"Usuário não encontrado, tentar novamente?", "Erro | Login", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dg == DialogResult.Yes) {
                        return;
                    }
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Entrar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                DBInfo.con.Close();
                DBInfo.con.Dispose();
            }
        }

        private void btnLoginStatus_Click(object sender, EventArgs e) {
            if (txtLoginUsuario.Text == string.Empty || txtLoginPassword.Text == string.Empty) {
                MessageBox.Show($"Campo não preenchido corretamente", "Erro | Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaDados();
            infos = new List<string>();

            DBInfo.sqlcmd = $"SELECT * FROM Login WHERE nome_usuario = '{DBInternal.LNomeUsuario}' or senha_usuario = '{DBInternal.LSenhaUsuario}'";

            try {
                DBInfo.AbrirConexão();

                reader = DBInfo.cmd.ExecuteReader();

                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        infos.Add(reader[i].ToString());
                    }
                }

                if (!reader.HasRows) {
                    MessageBox.Show($"Usuário não encontrado ou inválido, tente novamente", "Erro | Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (DBInternal.LNomeUsuario == infos[2] && DBInternal.LSenhaUsuario == infos[3]) {
                    MessageBox.Show($"Usuário: {infos[2]} \nStatus: {infos[6]}", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    dg = MessageBox.Show($"Usuário não encontrado, tentar novamente?", "Erro | Status", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dg == DialogResult.Yes) {
                        return;
                    }
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                DBInfo.con.Close();
                DBInfo.con.Dispose();
            }
        }

        private void btnLoginDica_Click(object sender, EventArgs e) {
            if (txtLoginUsuario.Text == string.Empty || txtLoginPassword.Text == string.Empty) {
                MessageBox.Show($"Campo não preenchido corretamente", "Erro | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregaDados();
            infos = new List<string>();

            DBInfo.sqlcmd = $"SELECT * FROM Login WHERE nome_usuario = '{DBInternal.LNomeUsuario}' or senha_usuario = '{DBInternal.LSenhaUsuario}'";

            try {
                DBInfo.AbrirConexão();

                reader = DBInfo.cmd.ExecuteReader();

                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        infos.Add(reader[i].ToString());
                    }
                }

                if (!reader.HasRows) {
                    MessageBox.Show($"Usuário não encontrado ou inválido, tente novamente", "Erro | Dica", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (DBInternal.LNomeUsuario == infos[2]) {
                    MessageBox.Show($"Dica de senha: {infos[5]}", "Dica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    dg = MessageBox.Show($"Usuário não encontrado, tentar novamente?", "Erro | Dica", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dg == DialogResult.Yes) {
                        return;
                    }
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Dica", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                DBInfo.con.Close();
                DBInfo.con.Dispose();
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e) {
            LoginCadastro lc = new LoginCadastro();
            lc.Show();
            lc.TopMost = false;
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e) {

        }
    }
}