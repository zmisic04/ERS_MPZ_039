using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public sealed class DodajGodisnjicuZahtjev
    {
        public string Naziv { get; init; } = string.Empty;
        public string Opis { get; init; } = string.Empty;
        public string NazivDogadjaja { get; init; } = string.Empty;
        public string Osobe { get; init; } = string.Empty;
        public DateTime Datum { get; init; }
        public int PodsjetnikDaniPrije { get; init; }
    }
}
