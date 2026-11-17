using Application.Contracts;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IUnosZapisa
    {
        Result<Guid> DodajRodjendan(DodajRodjendanZahtjev zahtjev);
    }
}
