using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TheWildOasis.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabinsController : ControllerBase
    {

        private readonly ILogger<CabinsController> _logger;
        private readonly DbContext _dbContext;

        public CabinsController(ILogger<CabinsController> logger, DbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetCabins")]
        public void Get()
        { }

        [HttpPost(Name = "PostCabins")]
        public IActionResult PostCabin([FromQuery] string name)
        {
            return Ok();
        }
    }
}
