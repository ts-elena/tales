using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalesApp.Data;
using TalesApp.Domain;

namespace aspdotnetcoreapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        private readonly TalesContext _context;

        public LinesController(TalesContext context)
        {
            _context = context;
        }

        // GET: api/Lines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Line>>> GetLines()
        {
            return await _context.Lines.ToListAsync();
        }

        // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Line>> GetLine(Guid id)
        {
            var line = await _context.Lines.FindAsync(id);

            if (line == null)
            {
                return NotFound();
            }

            return line;
        }

        // PUT: api/Lines/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLine(Guid id, Line line)
        {
            if (id != line.LineId)
            {
                return BadRequest();
            }

            _context.Entry(line).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineExists(id))
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

        // POST: api/Lines
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Line>> PostLine(Line line)
        {
            _context.Lines.Add(line);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLine", new { id = line.LineId }, line);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Line>> DeleteLine(Guid id)
        {
            var line = await _context.Lines.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }

            _context.Lines.Remove(line);
            await _context.SaveChangesAsync();

            return line;
        }

        private bool LineExists(Guid id)
        {
            return _context.Lines.Any(e => e.LineId == id);
        }
    }
}
