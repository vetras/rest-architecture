using layeredapi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace layeredApi.Services
{
    public interface ICarService
    {
        Task<List<Car>> GetAll();

        Task<Car> Create(Car car);
        
    }
}