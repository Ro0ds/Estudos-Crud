using System;
using CRUD.CodeGenerator;
using CRUD.Email;
using System.Windows.Forms;
using CRUD.Entities;

namespace CRUD.Sistema_de_Login {
    public partial class SenhaRecuperacao : Form {
        public string nome { get; private set; }
        public string usuario { get; private set; }
        public string email { get; private set; }
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        Login lg;
        CodigoRecuperacao cr;
        EmailSender es = new EmailSender();
        DateTime _startTime;

        public SenhaRecuperacao() {
            InitializeComponent();
        }

        public void CarregaDados() {
            DBInternal = new DatabaseInternal(
                    txtNomeRecupera.Text,
                    txtNomeUsuarioRecupera.Text,
                    txtEmailRecupera.Text
                );
        }

        private void SenhaRecuperacao_Load(object sender, EventArgs e) {
            CarregaDados();
            cr = new CodigoRecuperacao();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            nome = txtNomeRecupera.Text;
            usuario = txtNomeUsuarioRecupera.Text;
            email = txtEmailRecupera.Text;

            if (txtEmailRecupera.Text == string.Empty) {
                MessageBox.Show("Digite um e-mail", "Erro | Enviar E-mail Recuperação", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                es.SetarNome(nome);
                es.SetarEmail(email);
                es.SetarNomeUsuario(usuario);

                try {
                    es.EnviarEmailRecuperacao();
                    _startTime = DateTime.Now;
                    btnVerificaRecupera.Enabled = true;
                    txtCodigoRecupera.Enabled = true;
                    btnEnviar.Text = "Reenviar";
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Envio E-mail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void TemporarizadorDoCodigo() {
            TempoParaRecuperar.Enabled = true;
            TempoParaRecuperar.Interval = 1000;

            MessageBox.Show($"O código perderá a válidade em {DateTime.Now.AddMinutes(5)}");
        }

        private void TempoParaRecuperar_Tick(object sender, EventArgs e) {
            if (_startTime.AddMinutes(5) < DateTime.Now) {
                TempoParaRecuperar.Stop();
                cr.GerarCodigoSeguranca();
                MessageBox.Show("Tempo esgotado, gere outro código.", "Aviso | Recupera Senha", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVerificaRecupera_Click(object sender, EventArgs e) {
            if (txtCodigoRecupera.Text == es.CodigoSecreto) {
                TempoParaRecuperar.Stop();
                MessageBox.Show("Código correto!", "Aviso | Recupera Senha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Height = 437;
            }
            else {
                MessageBox.Show("Código errado, tente novamente", "Aviso | Recupera Senha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
        }

        private void btnResetaSenha_Click(object sender, EventArgs e) {
            lg = new Login();
            CarregaDados();

            if (txtSenha.Text != txtSenha2.Text || txtSenha.Text == string.Empty || txtSenha2.Text == string.Empty) {
                MessageBox.Show($"As senhas não correspondem ou não foram preenchidas.", "Erro | Recupera Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DBInfo = new DatabaseInfo(lg.conn);
                DBInfo.SetarConexao(lg.conn);

                DBInfo.sqlcmd = $"UPDATE Login " +
                    $"Set senha_usuario = \'{txtSenha2.Text}\' " +
                    $"where nome_usuario = \'{txtNomeUsuarioRecupera.Text}\';";

                try {
                    DBInfo.AbrirConexão();

                    int i = DBInfo.cmd.ExecuteNonQuery();

                    if(i > 0) {
                        MessageBox.Show("Senha alterada com sucesso!", "Aviso | Recupera Senha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        this.Height = 283;
                    }
                    else {
                        MessageBox.Show("Senha não alterada, contate um administrador!", "Erro | Recupera Senha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Recupera Senha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally {
                    DBInfo.con.Close();
                    DBInfo.con.Dispose();
                }
            }
        }
    }
}