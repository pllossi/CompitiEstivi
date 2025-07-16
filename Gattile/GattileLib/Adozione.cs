using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GattileLib
{
    public class Adozione
    {
        public Adozione(Adottante adottante, Gatto gatto, DateTime dataAdozione)
        {
            Adottante = adottante ?? throw new ArgumentNullException(nameof(adottante));
            Gatto = gatto ?? throw new ArgumentNullException(nameof(gatto));
            DataAdozione = dataAdozione;
        }

        public Gatto Gatto;

        public Adottante Adottante;

        public DateTime DataAdozione
        {
            get;
            private set;
        }
    }
}