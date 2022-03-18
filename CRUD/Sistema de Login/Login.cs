using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CRUD.Entities;
using System.Windows.Forms;

namespace CRUD.Sistema_de_Login {
    public partial class Login : Form {
        DatabaseInternal DBInternal;
        DatabaseInfo DBInfo;

        public Login() {
            InitializeComponent();

            DBInfo = new DatabaseInfo($@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog = CRUD; Integrated Security = True; MultipleActiveResultSets=true;");
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e) {

        }

        private void btnLoginStatus_Click(object sender, EventArgs e) {

        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e) {

        }
    }
}
