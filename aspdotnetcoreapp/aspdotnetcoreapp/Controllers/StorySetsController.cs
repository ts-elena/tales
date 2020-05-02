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
    public class StorySetsController : ControllerBase
    {
        private readonly TalesContext _context;

        public StorySetsController(TalesContext context)
        {
            _context = context;
        }

        // GET: api/StorySets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StorySet>>> GetStorySets()
        {
            return await _context.StorySets.ToListAsync();
        }

        // GET: api/StorySets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StorySet>> GetStorySet(Guid id)
        {
            var storySet = await _context.StorySets.FindAsync(id);

            if (storySet == null)
            {
                return NotFound();
            }

            return storySet;
        }

        // PUT: api/StorySets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStorySet(Guid id, StorySet storySet)
        {
            if (id != storySet.StorySetId)
            {
                return BadRequest();
            }

            _context.Entry(storySet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StorySetExists(id))
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

        // POST: api/StorySets
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StorySet>> PostStorySet(StorySet storySet)
        {
            _context.StorySets.Add(storySet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStorySet", new { id = storySet.StorySetId }, storySet);
        }

        // DELETE: api/StorySets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StorySet>> DeleteStorySet(Guid id)
        {
            var storySet = await _context.StorySets.FindAsync(id);
            if (storySet == null)
            {
                return NotFound();
            }

            _context.StorySets.Remove(storySet);
            await _context.SaveChangesAsync();

            return storySet;
        }

        private bool StorySetExists(Guid id)
        {
            return _context.StorySets.Any(e => e.StorySetId == id);
        }
    }
}
