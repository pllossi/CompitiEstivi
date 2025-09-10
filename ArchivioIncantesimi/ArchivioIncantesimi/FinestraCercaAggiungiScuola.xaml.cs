using System.Linq;
using System.Windows;

namespace ArchivioIncantesimi
{
    public partial class FinestraCercaAggiungiScuola : Window
    {
        private ArchivioIncantesimiGestore archivio;

        public FinestraCercaAggiungiScuola(ArchivioIncantesimiGestore archivio)
        {
            InitializeComponent();
            this.archivio = archivio;
        }

        private void BtnAggiungiScuola_Click(object sender, RoutedEventArgs e)
        {
            var inc = archivio.TrovaPerCRA(txtCRA.Text.Trim().ToUpper());
            var nuovaScuola = txtScuola.Text.Trim();
            if (inc == null)
            {
                lblEsito.Content = "Incantesimo non trovato.";
                return;
            }
            if (string.IsNullOrWhiteSpace(nuovaScuola))
            {
                lblEsito.Content = "Inserisci una scuola valida.";
                return;
            }
            if (inc.ScuoleMagia.Contains(nuovaScuola))
            {
                lblEsito.Content = "Scuola già presente.";
                return;
            }
            inc.ScuoleMagia.Add(nuovaScuola);
            inc.ScuoleMagia = inc.ScuoleMagia.Distinct().OrderBy(s => s).ToList();
            archivio.Salva();
            lblEsito.Content = "Scuola aggiunta!";
        }
    }
}
