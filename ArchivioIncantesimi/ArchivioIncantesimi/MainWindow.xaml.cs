using System.Windows;

namespace ArchivioIncantesimi
{
    public partial class MainWindow : Window
    {
        private ArchivioIncantesimiGestore archivio = new();

        public MainWindow()
        {
            InitializeComponent();
            archivio.Carica();
            lblTotale.Content = $"Totale: {archivio.NumeroTotale()}";
        }

        private void AggiungiIncantesimo_Click(object sender, RoutedEventArgs e)
        {
            var win = new FinestraAggiungiIncantesimo(archivio);
            win.ShowDialog();
            lblTotale.Content = $"Totale: {archivio.NumeroTotale()}";
        }

        private void VisualizzaIncantesimo_Click(object sender, RoutedEventArgs e)
        {
            var win = new FinestraVisualizzaIncantesimo(archivio);
            win.ShowDialog();
        }

        private void CercaAggiungiScuola_Click(object sender, RoutedEventArgs e)
        {
            var win = new FinestraCercaAggiungiScuola(archivio);
            win.ShowDialog();
        }

        private void VisualizzaPerScuola_Click(object sender, RoutedEventArgs e)
        {
            var win = new FinestraVisualizzaPerScuola(archivio);
            win.ShowDialog();
        }

        private void VisualizzaIncantesimi_Click(object sender, RoutedEventArgs e)
        {
            var win = new FinestraVisualizzaIncantesimi(archivio);
            win.ShowDialog();
        }
    }
}
