﻿using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    private List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car
            {
                Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice = 150,
                Description = "günlük kiralık araç"
            },
            new Car
            {
                Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2020, DailyPrice = 250,
                Description = "aylık kiralık araç"
            },
            new Car
            {
                Id = 3, BrandId = 2, ColorId = 1, ModelYear = 1999, DailyPrice = 100,
                Description = "haftalık kiralık araç"
            },
            new Car
            {
                Id = 4, BrandId = 2, ColorId = 3, ModelYear = 2010, DailyPrice = 100,
                Description = "aylık kiralık araç"
            },
            new Car
            {
                Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2001, DailyPrice = 99,
                Description = "günlük kiralık araç"
            },
        };
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public void Add(Car car)
    {
        _cars.Add(car);
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

    public void Delete(Car car)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        _cars.Remove(carToDelete);
    }

    public List<Car> GetById(int id)
    {
        return _cars.Where(c => c.Id == id).ToList();
    }
}