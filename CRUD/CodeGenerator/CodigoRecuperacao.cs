using System;
using CRUD.Email;
using System.Text;

namespace CRUD.CodeGenerator {
    class CodigoRecuperacao {
        public string CodigoSecreto { get; private set; }
        public string Nome { get; set; }

        public CodigoRecuperacao() { }
        public CodigoRecuperacao(string codigoSecreto, string nome) {
            CodigoSecreto = codigoSecreto;
            Nome = nome;
        }
        public CodigoRecuperacao(string nome) {
            Nome = nome;
        }

        public void GerarCodigoSeguranca() {
            CodigoSecreto = string.Empty;
            char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random rng = new Random();

            for (int i = 0; i <= 10; i++) {
                CodigoSecreto += alfabeto[rng.Next(26)].ToString() + rng.Next(99);
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Prezado(a) {Nome},");
            sb.AppendLine($"\nUtilize o código de segurança para recuperar sua senha.");
            sb.AppendLine($"Observação: o código expira em 5 minutos contando a partir de: {DateTime.Now.ToString("t")}");
            sb.AppendLine($"Código de segurança: {CodigoSecreto}");

            return sb.ToString();
        }
    }
}