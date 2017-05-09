using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using layeredapi.Models;
using layeredApi.Persistense;

namespace layeredApi.Services
{
    public class CarService : ICarService
    {
        private readonly ICarPersistence _db;

        public CarService(ICarPersistence db)
        {
            _db = db;
        }

        public Task<Car> Create(Car car)
        {
            car.Id = Guid.NewGuid();

            return _db.Save(car);
        }

        public Task<List<Car>> GetAll()
        {
            return _db.GetAll();            
        }
    }
}
