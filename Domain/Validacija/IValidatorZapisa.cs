using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validacija
{
    public interface IValidatorZapisa
    {
        string? Provjera(Zapis zapis, DateTime dan);
        //vraca null ako je sve dobro, inace poruku o gresci
    }
}
