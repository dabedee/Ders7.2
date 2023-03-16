using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,Description="1,1,1",ModelYear=2020,UnitPrice=600000},
                new Car{CarId=2,BrandId=2,ColorId=2,Description="2,2,2",ModelYear=2022,UnitPrice=900000}


            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c=>c.CarId==CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.CarId == car.CarId);
            carToUpdate.UnitPrice= car.UnitPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.Description=car.Description;
            

            

        }
    }
}
