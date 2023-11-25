using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWordController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetAysnc()
        {
            return  Ok("Hello");
        }
    }
}
