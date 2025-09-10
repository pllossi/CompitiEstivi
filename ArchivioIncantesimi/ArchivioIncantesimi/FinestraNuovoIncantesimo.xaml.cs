using ArchivioIncantesimiLib;
using System;
using System.Linq;
using System.Windows;
using ArchivioIncantesimiLib;


namespace ArchivioIncantesimi
{
    public partial class FinestraAggiungiIncantesimo : Window
    {
        private ArchivioIncantesimiGestore archivio;

        public FinestraAggiungiIncantesimo(ArchivioIncantesimiGestore archivio)
        {
            InitializeComponent();
            this.archivio = archivio;
        }

        private void BtnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCreatore.Text) ||
                dpData.SelectedDate == null || string.IsNullOrWhiteSpace(txtScuole.Text) ||
                !int.TryParse(txtLivello.Text, out int livello) || livello < 1 || livello > 10)
            {
                lblEsito.Content = "Compila tutti i campi correttamente.";
                return;
            }

            var scuole = txtScuole.Text.Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrEmpty(s)).Distinct().OrderBy(s => s).ToList();

            var incantesimo = new Incantesimo
            {
                CRA = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper(),
                Nome = txtNome.Text,
                Creatore = txtCreatore.Text,
                DataScoperta = dpData.SelectedDate.Value,
                ScuoleMagia = scuole,
                Disponibile = chkDisponibile.IsChecked ?? false,
                LivelloPericolo = livello
            };

            if (archivio.AggiungiIncantesimo(incantesimo))
            {
                MessageBox.Show($"Incantesimo '{incantesimo.Nome}' aggiunto con successo! \n Cra '{incantesimo.CRA}'", "Successo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                lblEsito.Content = "Incantesimo già presente!";
            }
        }
    }
}
