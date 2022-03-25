using System;

namespace CRUD {
    class DatabaseInternal {
        //COMEÇO BANCO CRUD//
        public int      CID { get; set; }
        public string   CNome { get; set; }
        public string   CNascimento { get; set; }
        public string   CNacionalidade { get; set; }
        public string   CEmail { get; set; }
        public string   CTelefone { get; set; }
        public string   CGenero { get; set; }
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

        public DatabaseInternal(string cNome, string cNascimento, string cNacionalidade, string cEmail, string cTelefone, string cGenero) {
            this.CNome =             cNome;
            this.CNascimento =       cNascimento;
            this.CNacionalidade =    cNacionalidade;
            this.CEmail =            cEmail;
            this.CTelefone =         cTelefone;
            this.CGenero =           cGenero;
        }

        public DatabaseInternal(int lID, string lNome, string lNomeUsuario, string lSenhaUsuario, string lEmailUsuario, string lDicaSenhaUsuario, string lStatusUsuario) {
            this.LID =               lID;
            this.LNome =             lNome;
            this.LNomeUsuario =      lNomeUsuario;
            this.LSenhaUsuario =     lSenhaUsuario;
            this.LEmailUsuario =     lEmailUsuario;
            this.LDicaSenhaUsuario = lDicaSenhaUsuario;
            this.LStatusUsuario =    lStatusUsuario;
        }

        public DatabaseInternal(string lNome, string lNomeUsuario, string lSenhaUsuario, string lEmailUsuario, string lDicaSenhaUsuario) {
            this.LNome = lNome;
            this.LNomeUsuario = lNomeUsuario;
            this.LSenhaUsuario = lSenhaUsuario;
            this.LEmailUsuario = lEmailUsuario;
            this.LDicaSenhaUsuario = lDicaSenhaUsuario;
        }
       
        public DatabaseInternal(string lStatusUsuario) {
            this.LStatusUsuario = lStatusUsuario;
        }

        public DatabaseInternal(string lNomeUsuario, string lSenhaUsuario) {
            this.LNomeUsuario =  lNomeUsuario;
            this.LSenhaUsuario = lSenhaUsuario;
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