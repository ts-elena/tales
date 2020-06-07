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
    using System.Linq;
    using Resources.PutResources;

    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly IStoryService _storyService;
        private readonly IMapper _mapper;

        public StoryController(IStoryService storyService, IMapper mapper)
        {
            _storyService = storyService;
            _mapper = mapper;
        }

        [HttpGet("GetStoryById/{storyId:Guid}", Name = "GetStoryById")]
        [ProducesResponseType(typeof(StoryResource), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StoryResource>> GetStoryById(Guid storyId)
        {
            var story = await _storyService.FindAsync(storyId);

            if (story == null) return NotFound();

            return _mapper.Map<Story, StoryResource>(story);
        }

        [HttpGet("{setId:Guid}")]
        [ProducesResponseType(typeof(List<StoryResource>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<StoryResource>>> GetAllActiveStoriesOfSet(Guid setId)
        {
            var stories = await _storyService.ActiveStoriesBySetId(setId);

            if (!stories.Any()) return NotFound();

            return _mapper.Map<List<Story>, List<StoryResource>>(stories);
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutStory(UpdateStoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var story = _mapper.Map<UpdateStoryResource, Story>(resource);
            var result = await _storyService.UpdateAsync(story);
            if (!result.Success) return BadRequest(result.Message);
            var storyResource = _mapper.Map<Story, StoryResource>(result.DbObject);

            return Ok(storyResource);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StoryResource>> PostStory([FromBody] SaveStoryResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var story = _mapper.Map<SaveStoryResource, Story>(resource);
            var result = await _storyService.SaveAsync(story);
            if (!result.Success) return BadRequest();
            return Ok(_mapper.Map<Story, StoryResource>(result.DbObject));
        }


        [HttpDelete("{storyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Story>> DeleteStory(Guid storyId)
        {
            var result = await _storyService.DeleteAsync(storyId);
            if (!result.Success) return NotFound();

            var story = _mapper.Map<Story, StoryResource>(result.DbObject);
            return Ok(story);
        }
    }
}
