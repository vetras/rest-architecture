using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using layeredApi.Services;
using System.Threading.Tasks;
using layeredapi.Models;

namespace layered_api.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private readonly ICarService _cars;

        public CarsController(ICarService s)
        {
            _cars = s;

        }

        [HttpGet]
        public Task<List<Car>> Get()
        {
            return _cars.GetAll();
        }

        [HttpPost]
        public Task<Car> Create([FromBody] Car car)
        {
            return _cars.Create(car);
        }

    }
}
