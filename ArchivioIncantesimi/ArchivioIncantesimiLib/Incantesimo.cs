using System;
using System.Collections.Generic;

namespace ArchivioIncantesimiLib
{
    public class Incantesimo
    {
        public string CRA { get; set; }
        public string Nome { get; set; }
        public string Creatore { get; set; }
        public DateTime DataScoperta { get; set; }
        public List<string> ScuoleMagia { get; set; } = new();
        public bool Disponibile { get; set; }
        public int LivelloPericolo { get; set; }
    }
}
