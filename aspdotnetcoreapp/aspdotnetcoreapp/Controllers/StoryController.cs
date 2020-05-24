namespace aspdotnetcoreapp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using aspdotnetcoreapp.Extentions;
    using aspdotnetcoreapp.Resourses;
    using aspdotnetcoreapp.Resourses.PostResources;
    using aspdotnetcoreapp.Services.ServiceInterfaces;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

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

        // GET: api/Stories
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StoryResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StoryResource>> GetStories()
        {
            IEnumerable<Story> stories = await _storyService.ListAsync();
            IEnumerable<StoryResource> storiesDto = _mapper.Map<IEnumerable<Story>, IEnumerable<StoryResource>>(stories);

            return storiesDto;
        }

        // GET: api/Stories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoryResource>> GetStory(Guid id)
        {
            Story story = await _storyService.FindAsync(id);
            StoryResource storyDto = _mapper.Map<Story, StoryResource>(story);

            if (storyDto == null)
            {
                return NotFound();
            }

            return storyDto;
        }

        // PUT: api/Stories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStory(Guid id, StoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            Story story = _mapper.Map<StoryResource, Story>(resource);
            Response<Story> result = await _storyService.UpdateAsync(id, story);
            if(!result.Success)
            {
                BadRequest();
            }
            var storyResource = _mapper.Map<Story, StoryResource>(result.DbObject);

            return Ok(storyResource);
        }

        [HttpPost]
        public async Task<ActionResult<Story>> PostStory([FromBody] SaveStoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            Story story = _mapper.Map<SaveStoryResource, Story>(resource);
            var result = await _storyService.SaveAsync(story);
            if (!result.Success)
            {
                return BadRequest();
            }
            var storyResource = _mapper.Map<Story, StoryResource>(result.DbObject);

            return Ok(storyResource);
        }

        // DELETE: api/Stories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Story>> DeleteStory(Guid id)
        {
            var result = await _storyService.DeleteAsync(id);
            if (!result.Success)
            {
                return NotFound();
            }

            StoryResource story = _mapper.Map<Story, StoryResource>(result.DbObject);
            return Ok(story);
        }
    }
}
