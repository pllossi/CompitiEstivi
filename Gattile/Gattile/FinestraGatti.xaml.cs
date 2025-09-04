using System.Windows;

namespace Gattile
{
    public partial class FinestraGatti : Window
    {
        public FinestraGatti(GestoreGattile gestore)
        {
            InitializeComponent();
            lstGatti.ItemsSource = gestore.gattiPresenti;
        }
    }
}
