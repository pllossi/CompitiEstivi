using System.Windows;

namespace Gattile
{
    public partial class FinestraAdozioni : Window
    {
        public FinestraAdozioni(GestoreGattile gestore)
        {
            InitializeComponent();
            lstAdozioni.ItemsSource = gestore.adozioni
                .Select(a => $"{a.Gatto.Nome} adottato da {a.Adottante} il {a.DataAdozione:dd/MM/yyyy}")
                .ToList();
        }
    }
}
