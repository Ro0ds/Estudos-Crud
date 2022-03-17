using System;

namespace CRUD {
    class Entities {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }

        public Entities() { }

        public Entities(string nome, string nascimento, string nacionalidade, string email, string telefone, string genero) {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Nacionalidade = nacionalidade;
            this.Email = email;
            this.Telefone = telefone;
            this.Genero = genero;
        }
    }
}