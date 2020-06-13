namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Resources;
    using Resources.PostResources;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using Resources.PutResources;

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
        public async Task<IEnumerable<StorySetNumberResource>> GetStorySetNumbers()
        {
            var storySetNumber = await _storySetsNumberService.ListAsync();
            IEnumerable<StorySetNumberResource> storySetNumberDto = _mapper
                .Map<IEnumerable<StorySetNumber>, IEnumerable<StorySetNumberResource>>(storySetNumber);
            return storySetNumberDto;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                return BadRequest(result.Message);
            }

            var storySetsResource = _mapper.Map<StorySetNumber, StorySetNumberResource>(result.DbObject);
            return Ok(storySetsResource);
        }

        /// <summary>
        /// Updates an existing story sets sequence according to an identifier.
        /// </summary>
        /// <param name="resource">Updated sequence data.</param>
        /// <returns>Response for the request.</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync([FromBody] UpdateStorySetNumberResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySetNumber = _mapper.Map<UpdateStorySetNumberResource, StorySetNumber>(resource);
            var result = await _storySetsNumberService.UpdateAsync(storySetNumber);

            if (!result.Success)
            {
                return BadRequest();
            }

            return Ok(_mapper.Map<StorySetNumber, StorySetNumberResource>(result.DbObject));
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
