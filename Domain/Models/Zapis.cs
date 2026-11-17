using Domain.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Models;

// Zajednički osnovni tip iz koga se mogu izvesti modeli konkretnog zadatka.
// Polja, nazive i nasledjivanje prilagoditi dodeljenoj specifikaciji.
public abstract class Zapis
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Naziv { get; init; } = string.Empty;
    public string Opis { get; init; } = string.Empty;
    public DateTimeOffset KreiranoUtc { get; init; } = DateTimeOffset.UtcNow;
    public DateTime Datum { get; init; }
    
    public int PodsjetnikDaniPrije { get; init; } = 0;
    public StatusPodsjetnika status { get; private set; } = StatusPodsjetnika.iskljucen;
    public abstract TipZapisa tip { get; }

    public abstract bool KojaOsoba(string imeOsobe);

    public bool ukljuciPodsjetnik() {
        if (status == StatusPodsjetnika.ukljucen)
            return false;   // onemogucavanje korisnicima da ukljuce nesto sto je vec uklkuceno
        status = StatusPodsjetnika.ukljucen;
        return true;
    }

    public bool iskljuciPodsjetnik()
    {
        if (status == StatusPodsjetnika.iskljucen)
            return false;   //isti slucaj kao u metodi iznad
        status = StatusPodsjetnika.iskljucen;
        return true;

    }

}
