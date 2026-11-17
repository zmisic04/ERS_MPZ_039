using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public sealed class DodajRodjendanZahtjev
    {
        public string NazivDogadjaja { get; init; } = String.Empty;
        public string ImeSlavljenika { get; init; } = String.Empty;
        public string OpisDogadjaja { get; init; } = string.Empty;
        public DateTime DatumRodjenja { get; init; }
        public int PodsjetnikDaniPrije { get; init; }

    }
}
