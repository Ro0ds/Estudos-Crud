using System;
using CRUD.CodeGenerator;
using CRUD.Email;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class SenhaRecuperacao : Form {
        CodigoRecuperacao cr;
        EmailSender es = new EmailSender();
        DateTime _startTime;

        public SenhaRecuperacao() {
            InitializeComponent();
        }

        private void SenhaRecuperacao_Load(object sender, EventArgs e) {
            cr = new CodigoRecuperacao();
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            if (txtEmailRecupera.Text == string.Empty) {
                MessageBox.Show("Digite um e-mail", "Erro | Enviar E-mail Recuperação", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                es.SetarNome(txtNomeRecupera.Text);
                es.SetarEmail(txtEmailRecupera.Text);

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
            }
        }
    }
}