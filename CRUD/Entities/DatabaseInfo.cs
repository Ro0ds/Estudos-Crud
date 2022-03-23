using System.Data;
using CRUD.Entities;
using System.Data.SqlClient;

namespace CRUD.Entities {
    class DatabaseInfo {
        public string           StringConexao { get; private set; }
        public SqlConnection    con { get; private set; }
        public string           sqlcmd { get; set; }
        public SqlCommand       cmd { get; set; }
        public DatabaseInfo     DBInfo { get; private set; }

        public DatabaseInfo() {}

        public DatabaseInfo(string stringConexao) {
            StringConexao = stringConexao;
        }

        public void SetarConexao(string stringConexao) {
            this.StringConexao = stringConexao;
        }

        public void AbrirConexão() {
            this.con = new SqlConnection(this.StringConexao);

            this.cmd = new SqlCommand(this.sqlcmd, this.con) {
                CommandType = CommandType.Text
            };

            this.con.Open();
        }
    }
}