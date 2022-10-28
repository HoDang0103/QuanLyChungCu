
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Framework.Web.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Framework.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly ApartmentDb _context;
        public ApartmentsController(ApartmentDb context)
        {
            _context = context;
        }
        // GET: api/<ApartmentsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.AbpApartments.ToListAsync());
        }

        // GET api/<ApartmentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApartmentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApartmentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApartmentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
