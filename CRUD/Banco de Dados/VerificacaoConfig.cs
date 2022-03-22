using System.Windows.Forms;

namespace CRUD.Banco_de_Dados {
    class VerificacaoConfig {
        public IniFile ArquivoINI { get; set; }
        public VerificacaoConfig() { }
        public void VerificaIni() {
            ArquivoINI = new IniFile(@"C:\tmp\Config.ini");

            if (!ArquivoINI.KeyExists("StrCon")) {
                DialogResult result = MessageBox.Show("Sem arquivo de configuração, deseja criar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    ArquivoINI.Write("StrCon", @"Data Source=LOCALHOST\SQLEXPRESS; Database = CRUD; User Id = sa; Password = Acesso@123; MultipleActiveResultSets=true");
                    MessageBox.Show(@"Arquivo de configuração criado em C:\tmp", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Sem arquivo de configuração, sistema não pode ser carregado corretamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
