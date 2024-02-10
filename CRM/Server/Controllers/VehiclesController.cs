using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.Server.Data;
using CRM.Shared.Domain;
using CRM.Server.IRepository;

namespace CRM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public VehiclesController(ApplicationDbContext context)
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Vehicles
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        public async Task<IActionResult> GetVehicles()
        {
            //if (_context.Vehicles == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Vehicles.ToListAsync();
            var Vehicles = await _unitOfWork.Vehicles.GetAll();
            return Ok(Vehicles);

        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        public async Task<IActionResult> GetVehicle(int id)
        {
            var Vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);

            if (Vehicle == null)
            {
                return NotFound();
            }

            return Ok(Vehicle);

            //if (_context.Vehicles == null)
            //{
            //    return NotFound();
            //}
            //  var Vehicle = await _context.Vehicles.FindAsync(id);

            //  if (Vehicle == null)
            //  {
            //      return NotFound();
            //  }

            //  return Vehicle;
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle Vehicle)
        {
            if (id != Vehicle.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Vehicle).State = EntityState.Modified;
            _unitOfWork.Vehicles.Update(Vehicle);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!VehicleExists(id))
                if (!await VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle Vehicle)
        {
            await _unitOfWork.Vehicles.Insert(Vehicle);
            await _unitOfWork.Save(HttpContext);
            //if (_context.Vehicles == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Vehicles'  is null.");
            //}
            //  _context.Vehicles.Add(Vehicle);
            //  await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicle", new { id = Vehicle.Id }, Vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var Vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            //if (_context.Vehicles == null)
            //{
            //    return NotFound();
            //}
            //var Vehicle = await _context.Vehicles.FindAsync(id);
            if (Vehicle == null)
            {
                return NotFound();
            }

            //_context.Vehicles.Remove(Vehicle);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool VehicleExists(int id)
        private async Task<bool> VehicleExists(int id)
        {
            var Vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            return Vehicle != null;
            //return (_context.Vehicles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
