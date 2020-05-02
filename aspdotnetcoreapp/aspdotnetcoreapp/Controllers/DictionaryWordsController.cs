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
    public class DictionaryWordsController : ControllerBase
    {
        private readonly TalesContext _context;

        public DictionaryWordsController(TalesContext context)
        {
            _context = context;
        }

        // GET: api/DictionaryWords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DictionaryWord>>> GetDictionaryWords()
        {
            return await _context.DictionaryWords.ToListAsync();
        }

        // GET: api/DictionaryWords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DictionaryWord>> GetDictionaryWord(Guid id)
        {
            var dictionaryWord = await _context.DictionaryWords.FindAsync(id);

            if (dictionaryWord == null)
            {
                return NotFound();
            }

            return dictionaryWord;
        }

        // PUT: api/DictionaryWords/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
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
            _context.DictionaryWords.Add(dictionaryWord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDictionaryWord", new { id = dictionaryWord.DictionaryWordId }, dictionaryWord);
        }

        // DELETE: api/DictionaryWords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DictionaryWord>> DeleteDictionaryWord(Guid id)
        {
            var dictionaryWord = await _context.DictionaryWords.FindAsync(id);
            if (dictionaryWord == null)
            {
                return NotFound();
            }

            _context.DictionaryWords.Remove(dictionaryWord);
            await _context.SaveChangesAsync();

            return dictionaryWord;
        }

        private bool DictionaryWordExists(Guid id)
        {
            return _context.DictionaryWords.Any(e => e.DictionaryWordId == id);
        }
    }
}
