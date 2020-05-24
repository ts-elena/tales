namespace aspdotnetcoreapp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using aspdotnetcoreapp.Extentions;
    using aspdotnetcoreapp.Resourses;
    using aspdotnetcoreapp.Resourses.PostResources;
    using aspdotnetcoreapp.Services;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using TalesApp.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class StorySetNumberController : ControllerBase
    {
        private readonly IStorySetNumberService _storySetsNumberService;
        private readonly IMapper _mapper;

        public StorySetNumberController(IStorySetNumberService storySetsNumberService, IMapper mapper)
        {
            _storySetsNumberService = storySetsNumberService;
            _mapper = mapper;
        }

        // GET: api/StorySetsNumber
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetNumberResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetNumberResource>> GetStorySetNumber()
        {
            var storySetNumber = await _storySetsNumberService.ListAsync();
            IEnumerable<StorySetNumberResource> storySetNumberDto = _mapper
                .Map<IEnumerable<StorySetNumber>, IEnumerable<StorySetNumberResource>>(storySetNumber);
            return storySetNumberDto;
        }

        // GET: api/StorySetNumber/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StorySetNumberResource>> GetStorySetNumber(Guid id)
        {
            var storySetsNumber = await _storySetsNumberService.FindAsync(id);

            StorySetNumberResource storySetNumberDto = _mapper
                .Map<StorySetNumber, StorySetNumberResource>(storySetsNumber);

            if (storySetsNumber == null)
            {
                return NotFound();
            }

            return storySetNumberDto;
        }

        [HttpPost]
        public async Task<IActionResult> PostStorySetNumber([FromBody] SaveStorySetNumberResource saveStorySetNumber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var storySetSequence = _mapper.Map<SaveStorySetNumberResource, StorySetNumber>(saveStorySetNumber);
            var result = await _storySetsNumberService.SaveAsync(storySetSequence);

            if (!result.Success)
            {
                return BadRequest();
            }

            var storySetsResource = _mapper.Map<StorySetNumber, StorySetNumberResource>(result.DbObject);
            return Ok(storySetsResource);
        }

        /// <summary>
        /// Updates an existing story sets sequence according to an identifier.
        /// </summary>
        /// <param name="id">Sequence identifier.</param>
        /// <param name="resource">Updated sequence data.</param>
        /// <returns>Response for the request.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(StorySetNumberResource), 200)]
        // [ProducesResponseType(typeof(ErrorResource), 400)]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] StorySetNumberResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySetNumber = _mapper.Map<StorySetNumberResource, StorySetNumber>(resource);
            var result = await _storySetsNumberService.UpdateAsync(id, storySetNumber);

            if (!result.Success)
            {
                return BadRequest();
            }

            var storySetNumberResource = _mapper.Map<StorySetNumber, StorySetNumberResource>(result.DbObject);
            return Ok(storySetNumberResource);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _storySetsNumberService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var storySetNumberResource = _mapper.Map<StorySetNumber, StorySetNumberResource>(result.DbObject);
            return Ok(storySetNumberResource);
        }
    }
}
