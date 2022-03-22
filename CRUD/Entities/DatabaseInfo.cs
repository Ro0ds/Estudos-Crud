namespace CRUD.Entities {
    class DatabaseInfo {
        public string StringConexao { get; private set; }

        public DatabaseInfo() {}

        public DatabaseInfo(string stringConexao) {
            StringConexao = stringConexao;
        }

        public void SetarConexao(string stringConexao) {
            this.StringConexao = stringConexao;
        }
    }
}