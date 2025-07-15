using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GattileLib
{
    public class Gatto
    {
        public Gatto()
        {
            throw new System.NotImplementedException();
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (value=="" || value==" ") { throw new ArgumentException(); }
                _nome = value;
            }
        }

        public string Razza
        {
            get
            {
                return _razza;
            }
            private set
            {
                if(value=="" || value==" ") { throw new ArgumentException(); }
                _razza = value;
            }
        }

        public bool Maschio
        {
            get ;
            private set;
        }

        private string _nome;

        private string _razza;

        public string? Descrizione
        {
            get => default;
            set
            {
                if(value=="" || value == " ") { throw new ArgumentException(); }
                field = value;
            }
        }

        public DateTime? DataUscita
        {
            get => default;
            set
            {
            }
        }

        public DateTime? DataNascita
        {
            get => default;
            set
            {
            }
        }

        public string CodiceId
        {
            get => default;
            private set
            {
            }
        }
    }
}