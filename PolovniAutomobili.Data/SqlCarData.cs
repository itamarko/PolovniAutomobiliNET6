using PolovniAutomobili.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili.Data
{
    public class SqlCarData : IAutomobiliData
    {
        private readonly PolovniAutomobiliDbContext db;

        public SqlCarData(PolovniAutomobiliDbContext polovniAutomobiliDbContext)
        {
            db = polovniAutomobiliDbContext;
        }
        public Automobil Add(Automobil newCar)
        {
            db.Car.Add(newCar);
            db.SaveChanges();
            return newCar;
        }

        public Automobil Delete(int id)
        {
            Automobil car = GetById(id);
            if (car != null)
            {
                db.Car.Remove(car);
                db.SaveChanges();
            }

            return car;
        }

        public Automobil GetById(int id)
        {
            return db.Car.Find(id);
        }

        public IEnumerable<Automobil> GetCarsByName(string name)
        {
            var query = from c in db.Car
                        where string.IsNullOrEmpty(name) || c.Name.Contains(name)
                        orderby c.Name
                        select c;
            return query;
        }

        public Automobil Update(Automobil updatedCar)
        {
            var entity = db.Car.Attach(updatedCar);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return updatedCar;
        }
    }
}
