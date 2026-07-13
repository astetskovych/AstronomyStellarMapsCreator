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

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            var categories = await _repository.GetCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("cats/search")]
        public async Task<IActionResult> Search(
        [FromQuery] string? name,
        [FromQuery] int? categoryId,
        [FromQuery] string? key)
        {
            var cats = await _repository.GetCatsFilteredAsync(name, categoryId, key);
            return Ok(cats);
        }
    }
}
