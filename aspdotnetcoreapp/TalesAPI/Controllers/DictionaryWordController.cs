namespace TalesAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryWordController : ControllerBase
    {
        private readonly TalesContext _context;

        public DictionaryWordController(TalesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DictionaryWord>>> GetDictionaryWords()
        {
            return await _context.DictionaryWord.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DictionaryWord>> GetDictionaryWord(Guid id)
        {
            var dictionaryWord = await _context.DictionaryWord.FindAsync(id);

            if (dictionaryWord == null)
            {
                return NotFound();
            }

            return dictionaryWord;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDictionaryWord(Guid id, DictionaryWord dictionaryWord)
        {
            if (id != dictionaryWord.DictionaryWordId)
            {
                return BadRequest();
            }

            _context.Entry(dictionaryWord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DictionaryWordExists(id))
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

        // POST: api/DictionaryWords
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DictionaryWord>> PostDictionaryWord(DictionaryWord dictionaryWord)
        {
            _context.DictionaryWord.Add(dictionaryWord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDictionaryWord", new { id = dictionaryWord.DictionaryWordId }, dictionaryWord);
        }

        // DELETE: api/DictionaryWords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DictionaryWord>> DeleteDictionaryWord(Guid id)
        {
            var dictionaryWord = await _context.DictionaryWord.FindAsync(id);
            if (dictionaryWord == null)
            {
                return NotFound();
            }

            _context.DictionaryWord.Remove(dictionaryWord);
            await _context.SaveChangesAsync();

            return dictionaryWord;
        }

        private bool DictionaryWordExists(Guid id)
        {
            return _context.DictionaryWord.Any(e => e.DictionaryWordId == id);
        }
    }
}
