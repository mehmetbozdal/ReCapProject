using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
            new Car {CarId=1, CategoryId=1, BrandId=1, ColorId=1, ModelYear=2006, DailyPrice=100000, Description="Ford"},
            new Car { CarId = 2, CategoryId = 2, BrandId = 2, ColorId = 1, ModelYear = 2006, DailyPrice = 100000, Description = "Mercedes" },
            new Car { CarId = 3, CategoryId = 1, BrandId = 1, ColorId = 1, ModelYear = 2006, DailyPrice = 100000, Description = "BMW" },
            new Car { CarId = 4, CategoryId = 4, BrandId =3, ColorId = 1, ModelYear = 2006, DailyPrice = 100000, Description = "Toyota" },
            new Car { CarId = 5, CategoryId = 3, BrandId = 1, ColorId = 1, ModelYear = 2006, DailyPrice = 100000, Description = "Volvo" },
        };
        }

        public List<Car> GetAll() {
            return _cars;
        }
        public void Add(Car car) {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.CategoryId = car.CategoryId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }

        //public List<Car> GetById(int CategoryId)
        //{
        //    return _cars.Where(c=>c.CategoryId == CategoryId).ToList();
        //}

        public void Delete(Car car) {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAllByCategory(int CategoryId)
        {
            return _cars.Where(c => c.CategoryId == CategoryId).ToList();
        }
    }
}
