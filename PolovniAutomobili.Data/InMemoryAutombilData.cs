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

        public Automobil Add(Automobil newCar)
        {
            newCar.Id = _cars.Max(c => c.Id) + 1;
            _cars.Add(newCar);
            return newCar;
        }

        public Automobil GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
            
        }

        public IEnumerable<Automobil> GetCarsByDescriotion(string description)
        {
            var cars = from c in _cars
                       where String.IsNullOrEmpty(description) || c.Description.ToLower().Contains(description.ToLower())
                       orderby c.Description
                       select c;
            return cars;
        }

        public Automobil Update(Automobil updatedCar)
        {
            var car = _cars.FirstOrDefault(c => c.Id == updatedCar.Id);
            if (car != null)
            {
                car.Description = updatedCar.Description;
                car.Gorivo = updatedCar.Gorivo;
            }
            return car;
        }
    }
}
