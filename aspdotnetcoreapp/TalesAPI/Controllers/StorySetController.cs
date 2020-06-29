namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Resources;
    using Resources.PostResources;
    using Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using Resources.PutResources;

    [Route("api/[controller]")]
    [ApiController]
    public class StorySetController : ControllerBase
    {
        private readonly IStorySetService _storySetService;
        private readonly IMapper _mapper;

        public StorySetController(IStorySetService storySetService, IMapper mapper)
        {
            _storySetService = storySetService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetResource>> GetStorySets()
        {
            var storySets = await _storySetService.ListAsync();
            var storySetDto = _mapper
                .Map<IEnumerable<StorySet>, IEnumerable<StorySetResource>>(storySets);
            return storySetDto;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StorySetResource), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StorySetResource>> GetStorySet(Guid id)
        {
            var storySet = await _storySetService.FindAsync(id);
            var storySetDto = _mapper.Map<StorySet, StorySetResource>(storySet);
            if (storySet == null) return NotFound();
            return storySetDto;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutStorySet([FromBody] UpdateStorySetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySet = _mapper.Map<UpdateStorySetResource, StorySet>(resource);
            var result = await _storySetService.UpdateAsync(storySet);

            if (!result.Success) return BadRequest();

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);

            return Ok(storySetResource);
        }

        [HttpPost]
        [ProducesResponseType(typeof(StorySetResource), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StorySetResource>> PostStorySet([FromBody] SaveStorySetResource saveStorySetResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySet = _mapper.Map<SaveStorySetResource, StorySet>(saveStorySetResource);
            var result = await _storySetService.SaveAsync(storySet);

            if (!result.Success) return BadRequest();

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);
            return Ok(storySetResource);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteStorySet(Guid id)
        {
            var result = await _storySetService.DeleteAsync(id);
            if (result == null) return NotFound();

            if (!result.Success)
                return BadRequest(result.Message);

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);
            return Ok(storySetResource);
        }
    }
}
