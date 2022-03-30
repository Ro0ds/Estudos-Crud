using System;
using CRUD.CodeGenerator;
using CRUD.Email;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class SenhaRecuperacao : Form {
        public string nome{ get; private set; }
        public string usuario { get; private set; }
        public string email { get; private set; }
        CodigoRecuperacao cr;
        EmailSender es = new EmailSender();
        DateTime _startTime;

        public SenhaRecuperacao() {
            InitializeComponent();
        }

        public SenhaRecuperacao(string nome, string usuario, string email) {
            this.nome = nome;
            this.usuario = usuario;
            this.email = email;
        }

        private void SenhaRecuperacao_Load(object sender, EventArgs e) {
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
            if(_startTime.AddMinutes(5) < DateTime.Now) {
                TempoParaRecuperar.Stop();
                cr.GerarCodigoSeguranca();
                MessageBox.Show("Tempo esgotado, gere outro código.", "Aviso | Recupera Senha", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVerificaRecupera_Click(object sender, EventArgs e) {
            if(txtCodigoRecupera.Text == es.CodigoSecreto) {
                TempoParaRecuperar.Stop();
                MessageBox.Show("Código correto, você será redirecionado para a tela de recuperação!", "Aviso | Recupera Senha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                AlterarSenha alterarSenha = new AlterarSenha();
                alterarSenha.Show();
            }
            else {
                MessageBox.Show("Código errado, tente novamente", "Aviso | Recupera Senha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
        }
    }
}