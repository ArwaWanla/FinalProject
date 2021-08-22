using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FragranceStoreAPI.Data;
using FragranceStoreAPI.Model;

namespace fragranceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FragrancesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FragrancesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Fragrances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fragrance>>> Getfragrances()
        {
            return await _context.fragrances.ToListAsync();
        }

        // GET: api/Fragrances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fragrance>> GetFragrance(string id)
        {
            var fragrance = await _context.fragrances.FindAsync(id);

            if (fragrance == null)
            {
                return NotFound();
            }

            return fragrance;
        }

        // PUT: api/Fragrances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFragrance(string id, Fragrance fragrance)
        {
            if (id != fragrance.productId)
            {
                return BadRequest();
            }

            _context.Entry(fragrance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FragranceExists(id))
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

        // POST: api/Fragrances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fragrance>> PostFragrance(Fragrance fragrance)
        {
            _context.fragrances.Add(fragrance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FragranceExists(fragrance.productId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFragrance", new { id = fragrance.productId }, fragrance);
        }

        // DELETE: api/Fragrances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFragrance(string id)
        {
            var fragrance = await _context.fragrances.FindAsync(id);
            if (fragrance == null)
            {
                return NotFound();
            }

            _context.fragrances.Remove(fragrance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FragranceExists(string id)
        {
            return _context.fragrances.Any(e => e.productId == id);
        }
    }
}
