using Microsoft.AspNetCore.Mvc;
using Missile.service;
using Missile.model;
namespace Missile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissleController : ControllerBase
    {
        public MissleController()
        {

        }
        MissleService service=new MissleService();
        [HttpGet]
        public IEnumerable<Missle> GetData()
        {
            return service.GetData();
        }
        [HttpPost]
        public bool post(Missle m)
        {
            return service.add(m);
        }
        [HttpGet]
        [Route("GetDataByCity")]
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return service.GetDataByCity(city);
        }


        [HttpGet]
        [Route("GetCities")]
        public IEnumerable<string> GetCities()
        {

            return service.GetCities();
        }
    }
}
