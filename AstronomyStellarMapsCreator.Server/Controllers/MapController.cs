namespace AstronomyStellarMapsCreator.Server.Controllers
{
    [ApiController]
    [Route("api/celestialObjects")]
    public class MapController : ControllerBase
    {
        private IRepository _repository;


        public MapController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<StarDTO>>> GetCelestialObjects()
        {
            var stars =  await _repository.GetCelestialObjectsAsync();
            return Ok(stars);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StarDTO>> GetGetCelestialObject(int id)
        {
            var star = await _repository.GetCelestialObjectAsync(id);

            if (star == null)
                return NotFound();

            return Ok(star);
        }
    }
}
