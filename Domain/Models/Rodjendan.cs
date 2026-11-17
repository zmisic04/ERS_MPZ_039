using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public sealed class Rodjendan:Zapis //iz ove klase se dalje ne moze nasledjivati
    {
        public string ImeSlavljenika { get; init; } = string.Empty;
        public override TipZapisa tip
        {
            get { return TipZapisa.rodjendan; }
        }

        public override bool KojaOsoba(string imeOsobe)
        {
            string imeMalimSl = ImeSlavljenika.ToLower();
            string trazenaOsoba = imeOsobe.ToLower();
            return imeMalimSl.Contains(trazenaOsoba);
        }

        public override string? ProvjeraZasebnih()
        {
            if (string.IsNullOrWhiteSpace(ImeSlavljenika))
                return "Ime slavljenika ne smije biti prazno.";

            return null;
        }
    }
}
