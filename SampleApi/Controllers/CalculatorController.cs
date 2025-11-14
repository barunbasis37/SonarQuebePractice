using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            return Ok(new { result = a + b });
        }
    }
}
