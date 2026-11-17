using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Models;
using Domain.Validacija;
using Shared;
using Application.Contracts;

namespace Application.Services;

// Polazna struktura servisa; poslovne operacije nisu implementirane.
public sealed class ZapisServis
{
    private readonly IZapisiRepozitorijum _repozitorijum;
    private readonly ILoggerServis _logger;

    private readonly IValidatorZapisa _validator;

    public ZapisServis(IZapisiRepozitorijum repozitorijum, ILoggerServis logger, IValidatorZapisa validator)
    {
        _repozitorijum = repozitorijum ?? throw new ArgumentNullException(nameof(repozitorijum));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _validator = validator ?? throw new ArgumentNullException(nameof(validator));
    }

    public Result<Guid> DodajRodjendan(DodajRodjendanZahtjev zahtjev)
    {
        Rodjendan rodjendan = new Rodjendan()
        {
            Naziv = zahtjev.NazivDogadjaja,
            Opis = zahtjev.OpisDogadjaja,
            ImeSlavljenika = zahtjev.ImeSlavljenika,
            Datum = zahtjev.DatumRodjenja,
            PodsjetnikDaniPrije = zahtjev.PodsjetnikDaniPrije
        };

        string? greska = _validator.Provjera(rodjendan, DateTime.Today);
        if (greska != null)
         {
            _logger.Loguj("Neuspjesno dodavanje rodjendana: " + greska);
            Result<Guid>.Failure("Zapis neispravan", greska);
        }

        Result sacuvano = _repozitorijum.Sacuvaj(rodjendan);
        if (sacuvano.IsFailure) {
            _logger.Loguj("Neuspjesno cuvanje rodjendana: " + sacuvano.Error!.Message);
            return Result<Guid>.Failure(sacuvano.Error.Code, sacuvano.Error.Message);
        }

        _logger.Loguj("Dodat rodjendan, id: " + rodjendan.Id);
        return Result<Guid>.Success(rodjendan.Id);
    }
}
