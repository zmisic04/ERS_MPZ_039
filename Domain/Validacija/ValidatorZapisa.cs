using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validacija
{
    public sealed class ValidatorZapisa:IValidatorZapisa
    {
        private const int MinDanaPodsjetnik = 0;
        private const int MaxDanaPodsjetnik = 30;
        private const int MinGodina = 1900;

        public string? Provjera(Zapis zapis, DateTime dan)
        {
            if (string.IsNullOrWhiteSpace(zapis.Naziv))
                return "Morate unijeti naziv.";
            if (string.IsNullOrWhiteSpace(zapis.Opis))
                return "Morate unijeti naziv.";

            string? greskaZasebnih = zapis.ProvjeraZasebnih();
            if (greskaZasebnih != null)
                return greskaZasebnih;

            if (zapis.Datum.Year < MinGodina)
                return "Unos datuma neispravan.";
            if (zapis.Datum.Date > dan.Date)
                return "Datum ne moze biti u buducnosti.";
            if (zapis.PodsjetnikDaniPrije < MinDanaPodsjetnik ||
                zapis.PodsjetnikDaniPrije > MaxDanaPodsjetnik)
                return "Podsjetnik izvan opsega.(0 do 30 dana)";

            return null;
        }
    }
}
