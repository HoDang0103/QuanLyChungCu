using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Framework.Web.Data;
using Framework.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ServiceDb _context;
        public ServiceController(ServiceDb context)
        {
            _context = context;
        }

        // GET: api/<ServiceController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.AbpServices.ToListAsync());
        }

        //// GET api/<ServiceController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    var a = await _context.AbpServices.FindAsync(id);
        //    if (a == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(a);
        //}

        // POST api/<ServiceController>
        [HttpPost]
        public async Task<IActionResult> Post(Service service)
        {
            var Service = new Service()
            {
                ServiceId = service.ServiceId,
                ServiceName = service.ServiceName,
                Describe = service.Describe,
                ServiceCharge = service.ServiceCharge,
                Cycle = service.Cycle,
                TypeService = service.TypeService,
                ResponsibleUnit = service.ResponsibleUnit,
            };
            await _context.AbpServices.AddAsync(Service);
            await _context.SaveChangesAsync();

            return Ok(Service);
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutService(string id, Service service)
        {
            var a = await _context.AbpServices.FindAsync(id);
            if (a != null)
            {
                //a.ApartmentId = apartment.ApartmentId;
                a.ServiceId = service.ServiceId;
                a.ServiceName = service.ServiceName;
                a.Describe = service.Describe;
                a.ServiceCharge = service.ServiceCharge;
                a.Cycle = service.Cycle;
                a.TypeService = service.TypeService;
                a.ResponsibleUnit = service.ResponsibleUnit;

                await _context.SaveChangesAsync();

                return Ok(a);
            }
            return NotFound();
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var a = await _context.AbpServices.FindAsync(id);
            if (a != null)
            {
                _context.Remove(a);
                await _context.SaveChangesAsync();

                return Ok(a);
            }
            return NotFound();
        }
    }
}
