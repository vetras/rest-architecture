using System.Collections.Generic;
using layeredapi.Models;
using NoDb;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace layeredApi.Persistense
{
    public class CarPersistence : ICarPersistence
    {
        private const string pid = "projectid";
        private IBasicQueries<Car> queries;
        private IBasicCommands<Car> commands;
                
        public CarPersistence(IBasicCommands<Car> c, IBasicQueries<Car> q)
        {
            commands = c;
            queries = q;
        }

        public async Task<List<Car>> GetAll()
        {
            var cars = await queries.GetAllAsync(pid).ConfigureAwait(false);
            
            return cars.ToList();
        }

        public async Task<Car> Save(Car car)
        {
            await commands.CreateAsync(pid, car.Id.ToString(), car);
            return await queries.FetchAsync(pid, car.Id.ToString());
        }
    }
}
