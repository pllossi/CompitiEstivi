using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ArchivioIncantesimiLib;

namespace ArchivioIncantesimi
{
    public class ArchivioIncantesimiGestore
    {
        private const string FilePath = "incantesimi.json";
        public List<Incantesimo> Incantesimi { get; set; } = new();

        public void Salva()
        {
            var json = JsonSerializer.Serialize(Incantesimi);
            File.WriteAllText(FilePath, json);
        }

        public void Carica()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                Incantesimi = JsonSerializer.Deserialize<List<Incantesimo>>(json) ?? new();
            }
        }

        public bool AggiungiIncantesimo(Incantesimo incantesimo)
        {
            if (Incantesimi.Any(i => i.CRA == incantesimo.CRA))
                return false;
            Incantesimi.Add(incantesimo);
            Salva();
            return true;
        }

        public Incantesimo? TrovaPerCRA(string cra) =>
            Incantesimi.FirstOrDefault(i => i.CRA == cra);

        public List<Incantesimo> TrovaPerScuola(string scuola) =>
            Incantesimi.Where(i => i.ScuoleMagia.Contains(scuola)).ToList();

        public int NumeroTotale() => Incantesimi.Count;
    }
}
