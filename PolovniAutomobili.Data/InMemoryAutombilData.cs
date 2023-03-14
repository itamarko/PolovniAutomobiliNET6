using PolovniAutomobili.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili.Data
{
    public class InMemoryAutombilData : IAutomobiliData
    {
        List<Automobil> _cars;

        public InMemoryAutombilData()
        {
            _cars = new List<Automobil>()
            {
                new Automobil() { Id = 1, Description = "Audi A3", Gorivo = Enums.GorivoVrsta.Benzin  },
                new Automobil() { Id = 2, Description = "Audi A4", Gorivo = Enums.GorivoVrsta.Dizel  },
                new Automobil() { Id = 3, Description = "Audi Q2", Gorivo = Enums.GorivoVrsta.Hibrid  },
                new Automobil() { Id = 4, Description = "Audi Q3", Gorivo = Enums.GorivoVrsta.Benzin  },
            };
        }
        IEnumerable<Automobil> IAutomobiliData.GetAll()
        {
            var cars = from c in _cars
                       orderby c.Description
                       select c;
            return cars;
        }
    }
}
