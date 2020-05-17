using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalesApp.Data;
using TalesApp.Domain;

namespace aspdotnetcoreapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineSequencesController : ControllerBase
    {
        private readonly TalesContext _context;

        public LineSequencesController(TalesContext context)
        {
            _context = context;
        }

        // GET: api/LineSequences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineSequence>>> GetLineSequences()
        {
            return await _context.LineSequences.ToListAsync();
        }

        // GET: api/LineSequences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LineSequence>> GetLineSequence(Guid id)
        {
            var lineSequence = await _context.LineSequences.FindAsync(id);

            if (lineSequence == null)
            {
                return NotFound();
            }

            return lineSequence;
        }

        // PUT: api/LineSequences/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLineSequence(Guid id, LineSequence lineSequence)
        {
            if (id != lineSequence.LineId)
            {
                return BadRequest();
            }

            _context.Entry(lineSequence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineSequenceExists(id))
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

        // POST: api/LineSequences
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LineSequence>> PostLineSequence(LineSequence lineSequence)
        {
            _context.LineSequences.Add(lineSequence);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LineSequenceExists(lineSequence.LineId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLineSequence", new { id = lineSequence.LineId }, lineSequence);
        }

        // DELETE: api/LineSequences/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LineSequence>> DeleteLineSequence(Guid id)
        {
            var lineSequence = await _context.LineSequences.FindAsync(id);
            if (lineSequence == null)
            {
                return NotFound();
            }

            _context.LineSequences.Remove(lineSequence);
            await _context.SaveChangesAsync();

            return lineSequence;
        }

        private bool LineSequenceExists(Guid id)
        {
            return _context.LineSequences.Any(e => e.LineId == id);
        }
    }
}
