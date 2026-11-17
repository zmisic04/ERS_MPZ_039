using Domain.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IZapisiCitaj // ugovor samo za citanje
    {
        Result<Zapis> Pronadji(Guid id);
        Result<IReadOnlyList<Zapis>> Svi(); 
    }
}
