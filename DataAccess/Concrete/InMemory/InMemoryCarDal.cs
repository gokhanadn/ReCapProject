using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, Description = "Audi", ModelYear = 2000},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 550, Description = "Audi", ModelYear = 2001},
                new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 600, Description = "BMW", ModelYear = 2005},
                new Car{Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 800, Description = "BMW", ModelYear = 2010},
                new Car{Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 900, Description = "Mercedes", ModelYear = 2010},
                new Car{Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 1500, Description = "Mercedes", ModelYear = 2015},
                new Car{Id = 7, BrandId = 3, ColorId = 5, DailyPrice = 2000, Description = "Mercedes", ModelYear = 2018},


            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandID)
        {
            return _cars.Where(car => car.BrandId == brandID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
