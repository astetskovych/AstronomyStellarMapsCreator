using AstronomyStellarMapsCreator.Server.Common;
using AstronomyStellarMapsCreator.Server.DTOs;


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
            var stars =  _repository.GetStars().ToList();
            return Ok(stars);
        }

        [HttpGet("{id}")]
        public ActionResult<StarDTO> GetStar(int id)
        {
            var star = _repository.GetStar(id);

            if (star == null)
                return NotFound();

            return Ok(star);
        }
    }
}
