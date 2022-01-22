using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        public FoodsController(IFood foodService)
        {

        }
    }
}
