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
            _cars = new List<Car> {
            new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=899, Description="Ultra Luxury"},
            new Car {Id=2, BrandId=2, ColorId=3, ModelYear=2020, DailyPrice=500, Description="Luxury"},
            new Car {Id=3, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=400, Description="Premium"},
            new Car {Id=4, BrandId=4, ColorId=2, ModelYear=2019, DailyPrice=200, Description="Standart"},
            new Car {Id=5, BrandId=5, ColorId=4, ModelYear=2018, DailyPrice=200, Description="Standart"},
            new Car {Id=6, BrandId=6, ColorId=1, ModelYear=2017, DailyPrice=150, Description="Economic"},
            new Car {Id=7, BrandId=7, ColorId=5, ModelYear=1976, DailyPrice=999, Description="Special"},
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

   

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }
    }
}
