using System;
using System.Data.SqlClient;
using CRUD.Banco_de_Dados;
using CRUD.Email;
using CRUD.Entities;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class AlterarSenha : Form {
        private string NomeUsuario, SenhaUsuario, EmailUsuario, conn;
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        EmailSender es;
        SenhaRecuperacao sr;
        VerificacaoConfig vConf = new VerificacaoConfig();

        public AlterarSenha() {
            InitializeComponent();

            vConf.VerificaIni();
            conn = vConf.ArquivoINI.Read("StrCon");
            DBInfo = new DatabaseInfo(conn);
            DBInfo.SetarConexao(conn);

            DBInfo = new DatabaseInfo(conn);
            DBInternal = new DatabaseInternal(NomeUsuario, SenhaUsuario);
            es = new EmailSender();
            sr = new SenhaRecuperacao();
        }

        private void AlterarSenha_Load(object sender, EventArgs e) {
            NomeUsuario = sr.nome;
            EmailUsuario = sr.email;
            SenhaUsuario = txtNovaSenha.Text;
        }

        private void btnAlteraSenha_Click(object sender, EventArgs e) {
            if(txtNovaSenha.Text != txtRepitaSenha.Text) {
                MessageBox.Show("Erro: as senhas não correspondem, tente novamente", "Erro | Atualizar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else {
                es.SetarNome(DBInternal.LNome);
                es.SetarNomeUsuario(DBInternal.LNomeUsuario);
                es.SetarEmail(DBInternal.LEmailUsuario);

                DBInfo.sqlcmd = $"UPDATE LOGIN " +
                    $"SET senha_usuario = \'{SenhaUsuario}\' " +
                    $"WHERE nome_usuario = \'{NomeUsuario}\'";

                try {
                    DBInfo.AbrirConexão();

                    int i = DBInfo.cmd.ExecuteNonQuery();

                    if (i > 0) {
                        MessageBox.Show("Senha alterada com sucesso!", "Aviso | Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Alterar Senha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally {
                    DBInfo.con.Close();
                    DBInfo.con.Dispose();
                }
            }
        }
    }
}