using AstronomyStellarMapsCreator.Server.Common;
using AstronomyStellarMapsCreator.Server.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AstronomyStellarMapsCreator.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarsController : ControllerBase
    {
        private IRepository _repository;


        public StarsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<StarDTO>> GetStars()
        {
            //Response.Headers.Add("X-Test", "CORS-CHECK");
            var stars =  _repository.GetStars().ToList();
            return Ok(stars);
        }
    }
}
