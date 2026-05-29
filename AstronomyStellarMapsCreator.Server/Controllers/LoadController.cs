namespace AstronomyStellarMapsCreator.Server.Controllers
{
    [Route("api/")]
    public class LoadController : Controller
    {
        private IRepository _repository;

        public LoadController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet("cats")]
        public async Task<ActionResult<IEnumerable<CatDTO>>> GetCats()
        {
            var cats = await _repository.GetCatsAsync();

            return Ok(cats.Take(100));
        }
    }
}
