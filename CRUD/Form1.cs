using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD {
    public partial class Form1 : Form {
        Entities en;
        string sqlcmd;
        string conStr = @"Data Source=INFRA01\SQLEXPRESS;Initial Catalog = CRUD; Integrated Security = True";
        SqlConnection con;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'cRUDDataSet.FirstCrud'. Você pode movê-la ou removê-la conforme necessário.
            //this.firstCrudTableAdapter.Fill(this.cRUDDataSet.FirstCrud);

            try {
                en = new Entities(
                    txtNome.Text,
                    dtNascimento.Value,
                    txtNacionalidade.Text,
                    txtEmail.Text,
                    txtTelefone.Text,
                    txtGenero.Text
                );
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro - Inicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            sqlcmd = $"INSERT INTO FirstCrud " +
                $"(nome, idade, nacionalidade, email, telefone, genero) " +
                $"VALUES (\'{en.Nome}\', \'{en.Nascimento}\', \'{en.Nacionalidade}\', \'{en.Email}\', \'{en.Telefone}\', \'{en.Genero}\')";

            try {
                con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand(sqlcmd, con) {
                    CommandType = CommandType.Text
                };

                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0) {
                    MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Erro: cadastro não realizado", "Erro - Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message);
            }
            finally {
                con.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            en.Nome = txtNome.Text;
            en.Nascimento = dtNascimento.Value;
            en.Nacionalidade = txtNacionalidade.Text;
            en.Email = txtEmail.Text;
            en.Telefone = txtTelefone.Text;
            en.Genero = txtGenero.Text;
            
            sqlcmd = $"UPDATE FirstCrud " +
                $"SET " +
                $"{en.Nome} = \'{txtNome.Text}\', " +
                $"{en.Nascimento} = {dtNascimento}, " +
                $"{en.Nacionalidade} = \'{txtNacionalidade.Text}\', " +
                $"{en.Email} = \'{txtEmail.Text}\', " +
                $"{en.Telefone} = \'{txtTelefone.Text}\', " +
                $"{en.Genero} = \'{txtGenero.Text}\'";

            try {
                con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand(sqlcmd, con) {
                    CommandType = CommandType.Text
                };

                con.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0) {
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro - Atualizar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            try {
                sqlcmd = $"SELECT * FROM FirstCrud";
                con = new SqlConnection(conStr);

                SqlCommand cmd = new SqlCommand(sqlcmd, con) {
                    CommandType = CommandType.Text
                };

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    firstCrudTableAdapter.Fill(cRUDDataSet.FirstCrud);
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro - Buscar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

        }
    }
}
