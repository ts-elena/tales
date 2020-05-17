using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspdotnetcoreapp.Extentions;
using aspdotnetcoreapp.Resourses;
using aspdotnetcoreapp.Resourses.PostResources;
using aspdotnetcoreapp.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalesApp.Data;
using TalesApp.Domain;
using TalesApp.Domain.Services;

namespace aspdotnetcoreapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorySetsSequencesController : ControllerBase
    {
        private readonly IService<StorySetsSequence> _storySetsSequenceService;
        private readonly IMapper _mapper;

        public StorySetsSequencesController(IService<StorySetsSequence> storySetsSequenceService, IMapper mapper)
        {
            _storySetsSequenceService = storySetsSequenceService;
            _mapper = mapper;
        }

        // GET: api/StorySetsSequences
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetsSequenceResourse>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetsSequenceResourse>> GetStorySetsSequences()
        {
            var storySetSequence = await _storySetsSequenceService.ListAsync();
            IEnumerable<StorySetsSequenceResourse> storySetSequenceDto = _mapper
                .Map<IEnumerable<StorySetsSequence>, IEnumerable<StorySetsSequenceResourse>>(storySetSequence);
            return storySetSequenceDto;
        }

        // GET: api/StorySetsSequences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StorySetsSequenceResourse>> GetStorySetsSequence(Guid id)
        {
            var storySetsSequence = await _storySetsSequenceService.FindAsync(id);

            StorySetsSequenceResourse storySetSequenceDto = _mapper
                .Map<StorySetsSequence, StorySetsSequenceResourse>(storySetsSequence);

            if (storySetsSequence == null)
            {
                return NotFound();
            }

            return storySetSequenceDto;
        }

        // POST: api/StorySetsSequences
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<IActionResult> PostStorySetsSequence([FromBody] SaveStorySetSequenceResource saveStorySetSequence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var storySetSequence = _mapper.Map<SaveStorySetSequenceResource, StorySetsSequence>(saveStorySetSequence);
            var result = await _storySetsSequenceService.SaveAsync(storySetSequence);

            if (!result.Success)
            {
                return BadRequest();
            }

            var storySetsResource = _mapper.Map<StorySetsSequence, StorySetsSequenceResourse>(result.DbObject);
            return Ok(storySetsResource);
        }

        /// <summary>
        /// Updates an existing story sets sequence according to an identifier.
        /// </summary>
        /// <param name="id">Sequence identifier.</param>
        /// <param name="resource">Updated sequence data.</param>
        /// <returns>Response for the request.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(StorySetsSequenceResourse), 200)]
        // [ProducesResponseType(typeof(ErrorResource), 400)]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] StorySetsSequenceResourse resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = _mapper.Map<StorySetsSequenceResourse, StorySetsSequence>(resource);
            var result = await _storySetsSequenceService.UpdateAsync(id, category);

            if (!result.Success)
            {
                return BadRequest();
            }

            var categoryResource = _mapper.Map<StorySetsSequence, StorySetsSequenceResourse>(result.DbObject);
            return Ok(categoryResource);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _storySetsSequenceService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<StorySetsSequence, StorySetsSequenceResourse>(result.DbObject);
            return Ok(categoryResource);
        }
    }
}
