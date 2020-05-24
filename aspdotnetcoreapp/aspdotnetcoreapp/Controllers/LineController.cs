namespace aspdotnetcoreapp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using aspdotnetcoreapp.Resourses;
    using aspdotnetcoreapp.Services.ServiceInterfaces;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using TalesApp.Data;
    using TalesApp.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly ILineService _lineService;
        private readonly IMapper _mapper;

        public LineController(ILineService service, IMapper mapper)
        {
            _lineService = service;
            _mapper = mapper;
        }

        // GET: api/Lines
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<LineResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<LineResource>> GetLines()
        {
            IEnumerable<Line> lines = await _lineService.ListAsync();
            IEnumerable<LineResource> linesDto = _mapper.Map<IEnumerable<Line>, IEnumerable<LineResource>>(lines);

            return linesDto;
        }

        /* // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Line>> GetLine(Guid id)
        {
            var line = await _context.Line.FindAsync(id);

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
            _context.Line.Add(line);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLine", new { id = line.LineId }, line);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Line>> DeleteLine(Guid id)
        {
            var line = await _context.Line.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }

            _context.Line.Remove(line);
            await _context.SaveChangesAsync();

            return line;
        }

        private bool LineExists(Guid id)
        {
            return _context.Line.Any(e => e.LineId == id);
        }*/
    }
}
