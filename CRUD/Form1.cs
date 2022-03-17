﻿using System;
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

        public void CarregaDados() {
            en = new Entities(
                    txtNome.Text,
                    txtNascimento.Text,
                    txtNacionalidade.Text,
                    txtEmail.Text,
                    txtTelefone.Text,
                    txtGenero.Text
                );
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'cRUDDataSet.FirstCrud'. Você pode movê-la ou removê-la conforme necessário.
            //this.firstCrudTableAdapter.Fill(this.cRUDDataSet.FirstCrud);
            //birthDate = dtNascimento.Value.ToString(@"dd/MM/yyyy");

            try {
                CarregaDados();
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro - Inicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;

            if (txtNome.Text == string.Empty && txtEmail.Text == string.Empty && txtTelefone.Text == string.Empty) {
                MessageBox.Show("Nome, e-mail ou telefone inválido, tente novamente.", "Erro - Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                try {
                    CarregaDados();
                    sqlcmd = $"INSERT INTO FirstCrud " +
                        $"VALUES (\'{en.Nome}\', \'{en.Nascimento}\', \'{en.Nacionalidade}\', \'{en.Email}\', \'{en.Telefone}\', \'{en.Genero}\')";

                    con = new SqlConnection(conStr);

                    SqlCommand cmd = new SqlCommand(sqlcmd, con) {
                        CommandType = CommandType.Text
                    };

                    con.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0) {
                        MessageBox.Show("Cadastro realizado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnInserir.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Erro: cadastro não realizado.", "Erro - Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro - Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally {
                    con.Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;

            CarregaDados();

            sqlcmd = $"UPDATE FirstCrud " +
                $"SET " +
                $"nome = \'{txtNome.Text}\', " +
                $"nascimento = \'{txtNascimento.Text}\', " +
                $"nacionalidade = \'{txtNacionalidade.Text}\', " +
                $"email = \'{txtEmail.Text}\', " +
                $"telefone = \'{txtTelefone.Text}\', " +
                $"genero = \'{txtGenero.Text}\' " +
                $"where telefone = {txtTelefone.Text}";

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
            dataGridView1.Enabled = true;
            btnInserir.Enabled = false;

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

                reader.Close();
            }
            catch (Exception a) {
                MessageBox.Show(a.Message, "Erro - Buscar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = true;
            btnInserir.Enabled = true;
            string countSQL, fixID;
            int i;

            if (txtDeletar.Text == string.Empty) {
                MessageBox.Show("Erro: campo inválido, tente novamente.", "Erro - Excluir", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else {
                try {
                    sqlcmd = $"DELETE FROM FirstCrud WHERE id = {txtDeletar.Text}";
                    countSQL = $"SELECT COUNT(*) as QTDE FROM FirstCrud";

                    con = new SqlConnection(conStr);

                    SqlCommand count = new SqlCommand(countSQL, con) {
                        CommandType = CommandType.Text
                    };

                    SqlCommand cmd = new SqlCommand(sqlcmd, con) {
                        CommandType = CommandType.Text
                    };

                    con.Open();

                    i = cmd.ExecuteNonQuery();

                    if (i > 0) {
                        MessageBox.Show("Cadastro deletado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    SqlDataReader sqlFIX = count.ExecuteReader();

                    while (sqlFIX.Read()) {
                        fixID = $"DBCC CHECKIDENT ('[FirstCrud]', RESEED, {sqlFIX[0]});";

                        SqlCommand fix = new SqlCommand(fixID, con) {
                            CommandType = CommandType.Text
                        };

                        i = fix.ExecuteNonQuery();

                        if (i > 0) {
                            MessageBox.Show("Número de ID corrigido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    sqlFIX.Close();
                }
                catch (Exception a) {
                    MessageBox.Show(a.Message, "Erro - Excluir", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally {
                    con.Close();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            dataGridView1.Enabled = false;
            cRUDDataSet.Clear();

            txtEmail.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtNacionalidade.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNascimento.Text = string.Empty;

            btnInserir.Enabled = true;
        }
    }
}