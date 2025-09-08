namespace ArchivioIncantesimiLib
{
    public class Incantesimo
    {
        private string _nome;
        private string _cra; // codice univoco degli incantesimi
        private string _creatore;
        private DateOnly _dataCreazione;
        private string _scuolaDiMagia;

        public string Nome
        {
            get { return _nome; }
            private set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome dell'incantesimo non può essere vuoto.");
                }
                _nome = value; 
            }
        }
        public string Cra => _cra; 

        public string Creatore
        {
            get => _creatore;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome del creatore non può essere vuoto.");
                }
                _creatore = value;
            }
        }
        public DateOnly DataCreazione
        {
            get => _dataCreazione;
            private set
            {
                _dataCreazione = value;
            }
        }

        public string ScuolaDiMagia
        {
            get => _scuolaDiMagia;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La scuola di magia non può essere vuota.");
                }
                _scuolaDiMagia = value;
            }
        }
        public Incantesimo(string nome , string creatore, DateOnly dataCreazione, string scuolaDiMagia)
        {
            Nome = nome;
            Creatore = creatore;
            DataCreazione = dataCreazione;
            ScuolaDiMagia = scuolaDiMagia;
            GeneraCra();
        }
        private void GeneraCra()
        {
            // Genera un codice univoco basato su nome, creatore e data di creazione
            _cra = $"{Nome.Substring(0, 3).ToUpper()}{Creatore.Substring(0, 3).ToUpper()}{DataCreazione:yyyyMMdd}";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Incantesimo other)
            {
                if (this.Nome == other.Nome)
                {
                    return true;
                }
                return this.Cra == other.Cra;
            }
            return false;
        }
    }
}
