using System.Windows;

namespace ArchivioIncantesimi
{
    public partial class FinestraVisualizzaPerScuola : Window
    {
        private ArchivioIncantesimiGestore archivio;

        public FinestraVisualizzaPerScuola(ArchivioIncantesimiGestore archivio)
        {
            InitializeComponent();
            this.archivio = archivio;
        }

        private void BtnVisualizza_Click(object sender, RoutedEventArgs e)
        {
            lstIncantesimi.Items.Clear();
            var scuola = txtScuola.Text.Trim();
            var lista = archivio.TrovaPerScuola(scuola);
            if (lista.Count == 0)
            {
                lstIncantesimi.Items.Add("Nessun incantesimo trovato.");
            }
            else
            {
                foreach (var inc in lista)
                {
                    lstIncantesimi.Items.Add($"{inc.CRA} - {inc.Nome} (Livello: {inc.LivelloPericolo})");
                }
            }
        }
    }
}
