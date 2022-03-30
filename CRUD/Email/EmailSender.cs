using System;
using CRUD.CodeGenerator;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CRUD.Email {
    class EmailSender {
        public string DestinatarioNome { get; private set; }
        public string DestinatarioNomeUsuario { get; private set; }
        public string DestinatarioEmail { get; private set; }
        public string CodigoSecreto { get; private set; }
        public MailAddress DoEmail { get; set; }
        public MailAddress ParaEmail { get; private set; }
        public MailMessage MensagemEmail { get; private set; }
        public SmtpClient smtpClient { get; set; }

        public EmailSender() { }
        public EmailSender(string destinatarioNome, string destinatarioEmail, MailAddress doEmail, MailAddress paraEmail, MailMessage mensagemEmail, SmtpClient smtpClient) {
            DestinatarioNome = destinatarioNome;
            DestinatarioEmail = destinatarioEmail;
            DoEmail = doEmail;
            ParaEmail = paraEmail;
            MensagemEmail = mensagemEmail;
            this.smtpClient = smtpClient;
        }

        public void SetarNome(string nome) {
            DestinatarioNome = nome;
        }

        public void SetarNomeUsuario(string nomeUser) {
            DestinatarioNomeUsuario = nomeUser;
        }

        public string PegarNome() {
            return DestinatarioNome;
        }

        public string PegarEmail() {
            return DestinatarioEmail;
        }

        public void SetarEmail(string email) {
            DestinatarioEmail = email;
        }

        public void EnviarEmailRecuperacao() {
            string nome = PegarNome();
            CodigoRecuperacao cr = new CodigoRecuperacao(nome);

            smtpClient = new SmtpClient() {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential() {
                    UserName = "contacrud@gmail.com",
                    Password = "HP159753HP4"
                }
            };

            CodigoSecreto = cr.GerarCodigoSeguranca();

            DoEmail = new MailAddress("contacrud@gmail.com", "Verificação");
            ParaEmail = new MailAddress(DestinatarioEmail, DestinatarioNome);

            MensagemEmail = new MailMessage() {
                From = DoEmail,
                Subject = "Código de verificação",
                Body = $"{cr}",
            };

            MensagemEmail.To.Add(ParaEmail);

            try {
                smtpClient.Send(MensagemEmail);
                MessageBox.Show("E-mail enviado com sucesso, verifique sua caixa de entrada e/ou caixa de spam.\nO Código de verificação irá durar apenas 5 minutos", "E-mail", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Envio E-mail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}