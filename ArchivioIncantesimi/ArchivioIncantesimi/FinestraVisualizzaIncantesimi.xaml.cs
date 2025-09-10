using System.Linq;
using System.Windows;

namespace ArchivioIncantesimi
{
    public partial class FinestraVisualizzaIncantesimi : Window
    {
        public FinestraVisualizzaIncantesimi(ArchivioIncantesimiGestore archivio)
        {
            InitializeComponent();
            var lista = archivio.Incantesimi
                .Select(i => new
                {
                    i.CRA,
                    i.Nome,
                    i.Creatore,
                    i.DataScoperta,
                    ScuoleMagiaString = string.Join(", ", i.ScuoleMagia),
                    i.Disponibile,
                    i.LivelloPericolo
                }).ToList();
            dgIncantesimi.ItemsSource = lista;
        }
    }
}
