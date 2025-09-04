using Gattile;
using System.Windows;
using System.Windows.Controls;

namespace Gattile
{
    public partial class PaginaIniziale : Window
    {
        GestoreGattile gestore = new GestoreGattile();

        public PaginaIniziale()
        {
            InitializeComponent();
            lblNumGatti.Content = gestore.gattiPresenti.Count.ToString();
        }

        private void btnVisualizzaGatti_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraGatti(gestore);
            finestra.Show();
        }

        private void btnNuovoGatto_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraNuovoGatto(gestore);
            finestra.Show();
        }

        private void btnVisualizzaAdozioni_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraAdozioni(gestore);
            finestra.Show();
        }

        private void btnNuovaAdozione_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraNuovaAdozione(gestore);
            finestra.Show();
        }

        private void btnAdozioneFallita_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraAdozioneFallita(gestore);
            finestra.Show();
        }
    }

}