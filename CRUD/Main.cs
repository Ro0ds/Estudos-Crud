using System;
using CRUD.Banco_de_Dados;
using CRUD.Entities;
using CRUD.Sistema_de_Login;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD {
    public partial class Main : Form {
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        VerificacaoConfig vConf = new VerificacaoConfig();
        string conn;


        public Main() {
            InitializeComponent();

            vConf.VerificaIni();
            conn = vConf.ArquivoINI.Read("StrCon");
            DBInfo = new DatabaseInfo(conn);
            DBInfo.SetarConexao(conn);
        }

        public void CarregaDados() {
            DBInternal = new DatabaseInternal(
                    txtNome.Text,
                    txtNascimento.Text,
                    txtNacionalidade.Text,
                    txtEmail.Text,
                    txtTelefone.Text,
                    txtGenero.Text
                );
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                CarregaDados();
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Inicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;

            if (txtNome.Text == string.Empty && txtEmail.Text == string.Empty && txtTelefone.Text == string.Empty) {
                MessageBox.Show("Nome, e-mail ou telefone inválido, tente novamente.", "Erro | Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                try {
                    CarregaDados();

                    DBInfo.AbrirConexão();

                    DBInfo.sqlcmd = $"INSERT INTO FirstCrud " +
                        $"VALUES (\'{DBInternal.CNome}\', \'{DBInternal.CNascimento}\', \'{DBInternal.CNacionalidade}\', \'{DBInternal.CEmail}\', \'{DBInternal.CTelefone}\', \'{DBInternal.CGenero}\')";

                    int i = DBInfo.cmd.ExecuteNonQuery();

                    if (i > 0) {
                        MessageBox.Show("Cadastro realizado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnInserir.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Erro: cadastro não realizado.", "Erro | Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally {
                    DBInfo.con.Close();
                    DBInfo.con.Dispose();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;

            CarregaDados();

            DBInfo.sqlcmd = $"UPDATE FirstCrud " +
                $"SET " +
                $"nome = \'{txtNome.Text}\', " +
                $"nascimento = \'{txtNascimento.Text}\', " +
                $"nacionalidade = \'{txtNacionalidade.Text}\', " +
                $"email = \'{txtEmail.Text}\', " +
                $"telefone = \'{txtTelefone.Text}\', " +
                $"genero = \'{txtGenero.Text}\' " +
                $"where telefone = {txtTelefone.Text}";

            try {
                DBInfo.AbrirConexão();

                int i = DBInfo.cmd.ExecuteNonQuery();

                if (i > 0) {
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Atualizar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                DBInfo.con.Close();
                DBInfo.con.Dispose();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;
            btnInserir.Enabled = false;

            try {
                DBInfo.sqlcmd = $"SELECT * FROM FirstCrud";
                DBInfo.AbrirConexão();

                SqlDataReader reader = DBInfo.cmd.ExecuteReader();

                while (reader.Read()) {
                    firstCrudTableAdapter.Fill(cRUDDataSet.FirstCrud);
                }

                reader.Close();
                reader.Dispose();
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro | Buscar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                DBInfo.con.Close();
                DBInfo.con.Dispose();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;
            btnInserir.Enabled = true;
            string countSQL, fixID;
            int i, b;

            if (txtDeletar.Text == string.Empty) {
                MessageBox.Show("Erro: campo inválido, tente novamente.", "Erro | Excluir", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else {
                try {
                    DBInfo.sqlcmd = $"DELETE FROM FirstCrud WHERE id = {txtDeletar.Text}";
                    countSQL = $"SELECT COUNT(*) as QTDE FROM FirstCrud";

                    SqlCommand count = new SqlCommand(countSQL, DBInfo.con) {
                        CommandType = CommandType.Text
                    };

                    i = DBInfo.cmd.ExecuteNonQuery();

                    if (i > 0) {
                        MessageBox.Show("Cadastro deletado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    SqlDataReader sqlFIX = count.ExecuteReader();

                    while (sqlFIX.Read()) {
                        fixID = $"DBCC CHECKIDENT ('[FirstCrud]', RESEED, {sqlFIX[0]});";

                        SqlCommand fix = new SqlCommand(fixID, DBInfo.con) {
                            CommandType = CommandType.Text
                        };

                        b = fix.ExecuteNonQuery();

                        if (b < 0) {
                            MessageBox.Show("Número de ID corrigido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    sqlFIX.Close();
                    sqlFIX.Dispose();
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro | Excluir", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally {
                    DBInfo.con.Close();
                    DBInfo.con.Dispose();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = false;
            cRUDDataSet.Clear();

            foreach (Control c in this.Controls) {
                if (c is TextBox && c.Tag.ToString() == "MainTXT" && c.Text != string.Empty) {
                    c.Text = string.Empty;
                }
            }
            btnInserir.Enabled = true;
        }
    }
}