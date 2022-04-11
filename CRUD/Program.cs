using System;
using CRUD.LocacaoCarros;
using CRUD.Banco_de_Dados;
using CRUD.Sistema_de_Login;
using System.Windows.Forms;

namespace CRUD {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LocacaoCarros.MMain());
        }
    }
}
