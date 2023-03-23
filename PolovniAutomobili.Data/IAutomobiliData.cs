using PolovniAutomobili.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili.Data
{
    public interface IAutomobiliData
    {
        IEnumerable<Automobil> GetCarsByName(string name);
        Automobil GetById(int id);
        Automobil Update(Automobil updatedCar);
        Automobil Add(Automobil newCar);
        Automobil Delete(int id);
    }
}
