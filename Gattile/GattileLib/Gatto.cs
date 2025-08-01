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
            _descrizione = null;
            DataUscita = null;
            DataNascita = null;
            CodiceId=CreateCodiceId();
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
                if(value=="" || value == " ") { throw new ArgumentException(); }
                _descrizione = value;
            }
        }

        private string? _descrizione;

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

        public string CodiceId ="";

        private string CreateCodiceId()
        {
            int numero = new Random().Next(1000, 9999);
            char PrimaLetteraMeseRegistrazione = DataArrivoGattile.ToString("MMM")[0];
            string AnnoRegistrazione = DataArrivoGattile.Year.ToString();
            string lettereRandom = "";
            for (int i = 0; i < 3; i++)
            {
                lettereRandom += (char)new Random().Next(65, 91); // Genera una lettera maiuscola casuale
            }
            return $"{numero}{PrimaLetteraMeseRegistrazione}{AnnoRegistrazione}{lettereRandom}";
        }
        

    }
}