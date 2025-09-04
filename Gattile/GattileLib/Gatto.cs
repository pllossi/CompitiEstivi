using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GattileLib
{
    public class Gatto
    {
        public Gatto(string nome = "", string razza = "", bool maschio = true, string? descrizione = null, DateTime? dataUscita = null, DateTime? dataNascita = null)
        {
            Nome = nome;
            Razza = razza;
            Maschio = maschio;
            Descrizione = descrizione;
            DataUscita = dataUscita;
            DataNascita = dataNascita;
            CodiceId = CreateCodiceId();
        }

        public string Nome
        {
            get => _nome;
            private set
            {
                if (value == "" || value == " ") { throw new ArgumentException(); }
                _nome = value;
            }
        }

        public DateTime DataArrivoGattile
        {
            get => _dataArrivoGattile;
            set
            {
                if (value.Subtract(DataUscita ?? DateTime.Now).TotalDays < 0)
                {
                    throw new ArgumentException("Data di arrivo non può essere precedente alla data di uscita.");
                }
                _dataArrivoGattile = value;
            }
        }

        private DateTime _dataArrivoGattile = DateTime.Now;

        public string Razza
        {
            get => _razza;
            private set
            {
                if (value == "" || value == " ") { throw new ArgumentException(); }
                _razza = value;
            }
        }

        public bool Maschio
        {
            get;
            private set;
        }

        private string _nome = string.Empty;

        private string _razza = string.Empty;

        private string? _descrizione = "";

        public string? Descrizione
        {
            get => _descrizione;
            set
            {
                if (value == "" || value == " ") { throw new ArgumentException(); }
                _descrizione = value;
            }
        }

        public DateTime? DataUscita
        {
            get;
            set;
        }

        public DateTime? DataNascita
        {
            get;
            set;
        }

        public string CodiceId = "";

        private string CreateCodiceId()
        {
            var rnd = new Random();
            int numero = rnd.Next(10000, 99999); // 5 cifre  
            char primaLetteraMese = DataArrivoGattile.ToString("MMM")[0];
            string anno = DataArrivoGattile.Year.ToString();
            string lettereRandom = new string(Enumerable.Range(0, 3)
                .Select(_ => (char)rnd.Next(65, 91)).ToArray());
            return $"{numero}{primaLetteraMese}{anno}{lettereRandom}";
        }
    }
}