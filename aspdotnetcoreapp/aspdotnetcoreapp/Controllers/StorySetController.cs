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
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

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

        // GET: api/StorySets
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetResource>> GetStorySets()
        {
            IEnumerable<StorySet> storySets = await _storySetService.ListAsync();
            IEnumerable<StorySetResource> storySetDto = _mapper
                .Map<IEnumerable<StorySet>, IEnumerable<StorySetResource>>(storySets);
            return storySetDto;
        }

        // GET: api/StorySets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StorySetResource>> GetStorySet(Guid id)
        {
            var storySet = await _storySetService.FindAsync(id);
            StorySetResource storySetDto = _mapper.Map<StorySet, StorySetResource>(storySet);
            if(storySet == null)
            {
                return NotFound();
            }
            return storySetDto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStorySet(Guid id, [FromBody] StorySetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            StorySet storySet = _mapper.Map<StorySetResource, StorySet>(resource);
            Response<StorySet> result = await _storySetService.UpdateAsync(id, storySet);

            if (!result.Success)
            {
                return BadRequest();
            }

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);

            return Ok(storySetResource);
        }

        [HttpPost]
        public async Task<ActionResult<StorySet>> PostStorySet([FromBody] SaveStorySetResource saveStorySetResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySet = _mapper.Map<SaveStorySetResource, StorySet>(saveStorySetResource);
            var result = await _storySetService.SaveAsync(storySet);

            if (!result.Success)
            {
                return BadRequest();
            }

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);
            return Ok(storySetResource);
        }

        // DELETE: api/StorySets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStorySet(Guid id)
        {
            var result = await _storySetService.DeleteAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            if (!result.Success)
                return BadRequest(result.Message);

            var storySetResource = _mapper.Map<StorySet, StorySetResource>(result.DbObject);
            return Ok(storySetResource);
        }
    }
}
