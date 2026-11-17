using Domain.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IZapisiUpis
    {
        Result Sacuvaj(Zapis zapis);
        Result Obrisi(Guid id);
    }
}
