using System.Windows;

namespace ArchivioIncantesimi
{
    public partial class FinestraVisualizzaIncantesimo : Window
    {
        private ArchivioIncantesimiGestore archivio;

        public FinestraVisualizzaIncantesimo(ArchivioIncantesimiGestore archivio)
        {
            InitializeComponent();
            this.archivio = archivio;
        }

        private void BtnCerca_Click(object sender, RoutedEventArgs e)
        {
            var inc = archivio.TrovaPerCRA(txtCRA.Text.Trim().ToUpper());
            if (inc == null)
            {
                txtDettagli.Text = "Incantesimo non trovato.";
            }
            else
            {
                txtDettagli.Text = $"CRA: {inc.CRA}\nNome: {inc.Nome}\nCreatore: {inc.Creatore}\nData: {inc.DataScoperta:dd/MM/yyyy}\nScuole: {string.Join(", ", inc.ScuoleMagia)}\nDisponibile: {(inc.Disponibile ? "Sì" : "No")}\nLivello Pericolo: {inc.LivelloPericolo}";
            }
        }
    }
}
