namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Models.PostModels;
    using Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using System.Linq;
    using Models.PutModels;

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

        [HttpGet("{storyId:Guid}")]
        [ProducesResponseType(typeof(StoryModel), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StoryModel>> GetStoryById(Guid storyId)
        {
            var story = await _storyService.FindAsync(storyId);

            if (story == null) return NotFound();

            return _mapper.Map<Story, StoryModel>(story);
        }

        [HttpGet("GetStoriesOfSet/{setId:Guid}", Name = "GetAllActiveStoriesOfSet")]
        [ProducesResponseType(typeof(List<StoryModel>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<StoryModel>>> GetAllStoriesOfSet(Guid setId)
        {
            var stories = await _storyService.StoriesBySetId(setId);

            if (!stories.Any()) return NotFound();

            return _mapper.Map<List<Story>, List<StoryModel>>(stories);
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutStory(UpdateStoryModel Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var story = _mapper.Map<UpdateStoryModel, Story>(Model);
            var result = await _storyService.UpdateAsync(story);
            if (!result.Success) return BadRequest(result.Message);
            var storyModel = _mapper.Map<Story, StoryModel>(result.DbObject);

            return Ok(storyModel);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StoryModel>> PostStory([FromBody] SaveStoryModel Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var story = _mapper.Map<SaveStoryModel, Story>(Model);
            var result = await _storyService.SaveAsync(story);
            if (!result.Success) return BadRequest();
            return Ok(_mapper.Map<Story, StoryModel>(result.DbObject));
        }


        [HttpDelete("{storyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Story>> DeleteStory(Guid storyId)
        {
            var result = await _storyService.DeleteAsync(storyId);
            if (!result.Success) return NotFound();

            var story = _mapper.Map<Story, StoryModel>(result.DbObject);
            return Ok(story);
        }
    }
}
