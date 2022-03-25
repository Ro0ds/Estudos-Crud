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
            StringConexao = stringConexao;
        }

        public void AbrirConexão() {
            con = new SqlConnection(StringConexao);

            cmd = new SqlCommand(sqlcmd, con) {
                CommandType = CommandType.Text
            };

            con.Open();
        }
    }
}