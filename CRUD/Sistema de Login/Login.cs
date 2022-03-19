using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CRUD.Banco_de_Dados;
using CRUD.Entities;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class Login : Form {
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;
        string cName = "CRUD.Properties.Settings.CRUDConnectionString";
        string conn = $@"Data Source=LOCALHOST\SQLEXPRESS; Database = CRUD; User Id = sa; Password = Acesso@123; MultipleActiveResultSets=true";

        public Login() {
            InitializeComponent();

            DBInfo = new DatabaseInfo();

            AppSetting cfg = new AppSetting();
            cfg.SaveConnectionString(cName, conn);

            DBInfo.SetarConexao(conn);
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e) {
            Main mn = new Main();
            mn.Show();
        }

        private void btnLoginStatus_Click(object sender, EventArgs e) {

        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e) {

        }

        private void menuCreateDB_Click(object sender, EventArgs e) {
            CriarBanco cb = new CriarBanco();
            cb.Show();
            cb.TopMost = true;
        }

        private void menuSelectDB_Click(object sender, EventArgs e) {

        }
    }
}
