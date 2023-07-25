using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartipicantsController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public PartipicantsController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/Partipicants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partipicant>>> GetParticipations()
        {
          if (_context.Participations == null)
          {
              return NotFound();
          }
            return await _context.Participations.ToListAsync();
        }

        // GET: api/Partipicants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partipicant>> GetPartipicant(string id)
        {
          if (_context.Participations == null)
          {
              return NotFound();
          }
            var partipicant = await _context.Participations.FindAsync(id);

            if (partipicant == null)
            {
                return NotFound();
            }

            return partipicant;
        }

        // PUT: api/Partipicants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartipicant(string id, Partipicant partipicant)
        {
            if (id != partipicant.PartipicantId)
            {
                return BadRequest();
            }

            _context.Entry(partipicant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartipicantExists(id))
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

        // POST: api/Partipicants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Partipicant>> PostPartipicant(Partipicant partipicant)
        {
          if (_context.Participations == null)
          {
              return Problem("Entity set 'QuizDbContext.Participations'  is null.");
          }
            _context.Participations.Add(partipicant);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PartipicantExists(partipicant.PartipicantId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPartipicant", new { id = partipicant.PartipicantId }, partipicant);
        }

        // DELETE: api/Partipicants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartipicant(string id)
        {
            if (_context.Participations == null)
            {
                return NotFound();
            }
            var partipicant = await _context.Participations.FindAsync(id);
            if (partipicant == null)
            {
                return NotFound();
            }

            _context.Participations.Remove(partipicant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PartipicantExists(string id)
        {
            return (_context.Participations?.Any(e => e.PartipicantId == id)).GetValueOrDefault();
        }
    }
}
