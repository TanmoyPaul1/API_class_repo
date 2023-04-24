using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandmarksController : ControllerBase
    {
        private readonly FinalProjectDBContext _context;

        public LandmarksController(FinalProjectDBContext context)
        {
            _context = context;
        }

        // GET: api/Landmarks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Landmark>>> GetLandmarks()
        {
          if (_context.Landmarks == null)
          {
              return NotFound();
          }
            return await _context.Landmarks.ToListAsync();
        }

        // GET: api/Landmarks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Landmark>> GetLandmark(int id)
        {
          if (_context.Landmarks == null)
          {
              return NotFound();
          }
            var landmark = await _context.Landmarks.FindAsync(id);

            if (landmark == null)
            {
                return NotFound();
            }

            return landmark;
        }

        // PUT: api/Landmarks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLandmark(int id, Landmark landmark)
        {
            if (id != landmark.LandmarkID)
            {
                return BadRequest();
            }

            _context.Entry(landmark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LandmarkExists(id))
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

        // POST: api/Landmarks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Landmark>> PostLandmark(Landmark landmark)
        {
          if (_context.Landmarks == null)
          {
              return Problem("Entity set 'FinalProjectDBContext.Landmarks'  is null.");
          }
            _context.Landmarks.Add(landmark);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLandmark", new { id = landmark.LandmarkID }, landmark);
        }

        // DELETE: api/Landmarks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLandmark(int id)
        {
            if (_context.Landmarks == null)
            {
                return NotFound();
            }
            var landmark = await _context.Landmarks.FindAsync(id);
            if (landmark == null)
            {
                return NotFound();
            }

            _context.Landmarks.Remove(landmark);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LandmarkExists(int id)
        {
            return (_context.Landmarks?.Any(e => e.LandmarkID == id)).GetValueOrDefault();
        }
    }
}
