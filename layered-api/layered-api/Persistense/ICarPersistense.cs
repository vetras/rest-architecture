using layeredapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace layeredApi.Persistense
{
    public interface ICarPersistence
    {
        Task<List<Car>> GetAll();
        Task<Car> Save(Car car);
    }
}