using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GattileLib
{
    public class Adottante
    {
        public Adottante(Adottante adottante)
        {
            if (adottante == null) throw new ArgumentNullException(nameof(adottante));
            Nome = adottante.Nome;
            Cognome = adottante.Cognome;
            Indirizzo = adottante.Indirizzo;
            Telefono = adottante.Telefono;
        }

        public string Nome
        {
            get;
            private set;
        }

        public string Cognome
        {
            get;
            private set;
        }

        public string Indirizzo
        {
            get;
            private set;
        }

        public int Telefono
        {
            get;
            private set;
        }
    }
}