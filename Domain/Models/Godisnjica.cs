using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class Godisnjica:Zapis
    {
        public string NazivDogadjaja { get; init; } = String.Empty;
        public string Osobe { get; init; } = String.Empty;

        public override TipZapisa tip
        {
            get { return TipZapisa.godisnjica; }
        }

        public override bool KojaOsoba(string imeOsobe)
        {
            string osobeMala = Osobe.ToLower();
            string trazeni = imeOsobe.ToLower();
            return osobeMala.Contains(trazeni);
        }

        public override string? ProvjeraZasebnih()
        {
            if (string.IsNullOrWhiteSpace(NazivDogadjaja))
                return "Naziv dogadjaja ne smije biti prazan.";
            
            return null;
        }
    }
}
