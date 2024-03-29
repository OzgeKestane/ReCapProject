﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car { Id = 1,BrandId=1,ColorId = 1,ModelYear=2015,DailyPrice=3000,Description="Otomatik"},
            //    new Car { Id = 2,BrandId=1,ColorId = 2,ModelYear=2022,DailyPrice=5000,Description="Otomatik"},
            //    new Car { Id = 3,BrandId=2,ColorId = 1,ModelYear=2020,DailyPrice=3700,Description="Manuel"},
            //    new Car { Id = 1,BrandId=2,ColorId = 1,ModelYear=2023,DailyPrice=6000,Description="Otomatik"},

            //};
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        //BrandId, ColorId, ModelYear, DailyPrice, Description

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
