
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ResourseJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("")]
        public IActionResult Index()
        {
            //using ApplicationContext db = new ApplicationContext();
            //{
            //    return db.product.ToList();
            //}
            return Ok();
        }
        
    }
}
