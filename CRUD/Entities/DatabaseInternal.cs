using System;

namespace CRUD {
    class DatabaseInternal {
        //COMEÇO BANCO CRUD//
        public int      ID { get; set; }
        public string   Nome { get; set; }
        public string   Nascimento { get; set; }
        public string   Nacionalidade { get; set; }
        public string   Email { get; set; }
        public string   Telefone { get; set; }
        public string   Genero { get; set; }
        //FIM BANCO CRUD//

        //COMEÇO BANCO USUÁRIOS//
        public int      LID { get; set; }
        public string   LNome { get; set; }
        public string   LNomeUsuario { get; private set; }
        public string   LSenhaUsuario { get; private set; }
        public string   LEmailUsuario { get; private set; }
        public string   LDicaSenhaUsuario { get; set; }
        public string   LStatusUsuario { get; set; }
        //FIM BANCO USUÁRIOS//

        public DatabaseInternal() { }

        public DatabaseInternal(string nome, string nascimento, string nacionalidade, string email, string telefone, string genero) {
            this.Nome =             nome;
            this.Nascimento =       nascimento;
            this.Nacionalidade =    nacionalidade;
            this.Email =            email;
            this.Telefone =         telefone;
            this.Genero =           genero;
        }

        public DatabaseInternal(int lID, string lNome, string lNomeUsuario, string lSenhaUsuario, string lEmailUsuario, string lDicaSenhaUsuario, string lStatusUsuario) {
            LID =               lID;
            LNome =             lNome;
            LNomeUsuario =      lNomeUsuario;
            LSenhaUsuario =     lSenhaUsuario;
            LEmailUsuario =     lEmailUsuario;
            LDicaSenhaUsuario = lDicaSenhaUsuario;
            LStatusUsuario =    lStatusUsuario;
        }

        public DatabaseInternal(string lNomeUsuario, string lSenhaUsuario) {
            LNomeUsuario =  lNomeUsuario;
            LSenhaUsuario = lSenhaUsuario;
        }

        public void AlterarLNome(string lNome) {
            LNomeUsuario = lNome;
        }

        public void AlterarLSenha(string lSenha) {
            LSenhaUsuario = lSenha;
        }

        public void AlterarLEmail(string lEmail) {
            LEmailUsuario = lEmail;
        }
    }
}