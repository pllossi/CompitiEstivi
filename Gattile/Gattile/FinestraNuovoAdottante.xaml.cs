using System.Windows;
using GattileLib;

namespace Gattile
{
    public partial class FinestraNuovoAdottante : Window
    {
        private GestoreGattile gestore;

        public FinestraNuovoAdottante(GestoreGattile gestore)
        {
            InitializeComponent();
            this.gestore = gestore;
        }

        private void btnSalva_Click(object sender, RoutedEventArgs e)
        {
            var adottante = new Adottante
            {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };
            gestore.InserisciAdottante(adottante);
            Close();
        }
    }
}
